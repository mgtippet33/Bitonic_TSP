using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitonicTour
{
    public partial class Form1 : Form
    {
        List<MyPoint> points = new List<MyPoint>();
        DebugBitonicTour bitonicDebug;
        PersistentStack stack;
        int rowPoints;
        int columnPoints;
        public Form1()
        {
            InitializeComponent();
        }
        private void PointsDraw()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            if (points.Count == 0)
            {
                pictureBox1.Image = bmp;
                return;
            }
            for(int i = 0; i < points.Count; ++i)
            {
                pictureBox1.Image = points[i].Draw(bmp);
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MyPoint point = new MyPoint(e.X, e.Y);
                points.Add(point);
                PointsDraw();
            }
            else if (e.Button == MouseButtons.Right)
            {
                for (int i = 0; i < points.Count; ++i)
                {
                    if (points[i] == null)
                        continue;
                    if (Math.Sqrt(Math.Pow(points[i].X - e.X, 2) + Math.Pow(points[i].Y - e.Y, 2)) <= 5)
                    {
                        points.RemoveAt(i);
                        PointsDraw();
                        return;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(points.Count < 3)
            {
                MessageBox.Show("Для запуска необходимо, как минимум 3 вершины!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            points.Sort((x, y) => x.X.CompareTo(y.X));
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            BitonicTour bitonicTour = new BitonicTour(points);
            pictureBox1.Image = bitonicTour.BitonicTourDraw(bmp);
            label1.Text = label1.Text = label1.Text.Substring(0, 26) + Math.Round(bitonicTour.optimalTour,2).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.lineColor = Color.Red;
            Program.circleColor = Color.Red;
            points.Clear();
            PointsDraw();
            label1.Text = label1.Text.Substring(0, 26);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 48 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void цветВершинToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Program.circleColor = colorDialog1.Color;
        }

        private void цветЛинииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Program.lineColor = colorDialog1.Color;
        }

        private void размерВершиныToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditSize edit = new EditSize("circle");
            edit.ShowDialog();
        }

        private void размерЛинииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditSize edit = new EditSize("line");
            edit.ShowDialog();
        }

        private void AutomationDebug(int speed)
        {
            if (points.Count < 3)
            {
                MessageBox.Show("Для отладки необходимо, как минимум 3 вершины!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ручнаяToolStripMenuItem.Enabled = false;
            PointsDraw();
            BitonicTour bitonicTour = new BitonicTour(points);
            double[,] recovery = bitonicTour.GetRecovery();
            DebugBitonicTour debug = new DebugBitonicTour(recovery, points);
            debug.AutomationDebug(ref pictureBox1, speed);
            ручнаяToolStripMenuItem.Enabled = true;
        }

        private void ручнаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (points.Count < 3)
            {
                MessageBox.Show("Для отладки необходимо, как минимум 3 вершины!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            button1.Visible = false;
            button4.Visible = false;
            button2.Visible = true;
            button3.Visible = true;
            button5.Visible = true;
            автоматическаяToolStripMenuItem.Enabled = false;
            pictureBox1.Enabled = false;
            PointsDraw();
            rowPoints = 0;
            columnPoints = 1;
            BitonicTour bitonic = new BitonicTour(points);
            double[,] recovery = bitonic.GetRecovery();
            bitonicDebug = new DebugBitonicTour(recovery, points);
            stack = new PersistentStack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(rowPoints < points.Count - 1)
            {
                bitonicDebug.ManualDebug(ref pictureBox1, rowPoints, columnPoints, ref stack);
                ++rowPoints;
                ++columnPoints;
            }
            else if (rowPoints == points.Count - 1)
            {
                bitonicDebug.LastManualDebug(ref pictureBox1, ref stack);
                ++rowPoints;
                ++columnPoints;
            }
            if(stack.versions.Count == points.Count)
            {
                button2.Enabled = false;
            }
            else if(stack.versions.Count != points.Count)
            {
                button2.Enabled = true;
                button3.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(rowPoints > 0)
            {
                bitonicDebug.ManualBackDebug(ref pictureBox1, ref stack);
                --rowPoints;
                --columnPoints;
            }
            if (stack.versions.Count == 0)
            {
                button3.Enabled = false;
            }
            else if (stack.versions.Count != 0)
            {
                button2.Enabled = true;
                button3.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PointsDraw();
            button1.Visible = true;
            button4.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
            button5.Visible = false;
            автоматическаяToolStripMenuItem.Enabled = true;
            pictureBox1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false;
        }

        private void быстроToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutomationDebug(500);
        }

        private void среднеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutomationDebug(1500);
        }

        private void медленноToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutomationDebug(2500);
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }
}
