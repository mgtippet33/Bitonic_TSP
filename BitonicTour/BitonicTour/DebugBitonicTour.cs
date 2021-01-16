using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitonicTour
{
    class DebugBitonicTour
    {
        private double[,] recovery;
        public int[] connections;
        private List<MyPoint> points;
        private int n;

        public DebugBitonicTour(double[,] recovery, List<MyPoint> points)
        {
            this.n = points.Count;
            this.recovery = recovery;
            this.connections = new int[n];
            this.points = points;

        }

        public void AutomationDebug(ref PictureBox pictureBox, int speed)
        {
            Bitmap bmp = (Bitmap)pictureBox.Image;
            Graphics graph;
            Pen circlePen = new Pen(Program.circleColor, Program.circleSize);
            Pen linePen = new Pen(Program.lineColor, Program.lineSize);
            Size size = new Size(Program.circleSize, Program.circleSize);
            for (int i = 0, j = 1; i < n - 1; ++i, ++j)
            {
                graph = Graphics.FromImage(bmp);
                int k = Convert.ToInt32(recovery[i, j]);
                int iCopy = i - 1;
                while (connections[k] > 1 && iCopy >= 0)
                {
                    k = Convert.ToInt32(recovery[iCopy, j]);
                    --iCopy;
                }
                graph.DrawLine(linePen, new Point(points[k].X, points[k].Y), new Point(points[j].X, points[j].Y));
                graph.DrawEllipse(circlePen, new Rectangle(new Point(points[k].X - 5, points[k].Y - 5), size));
                graph.DrawEllipse(circlePen, new Rectangle(new Point(points[j].X - 5, points[j].Y - 5), size));
                ++connections[k];
                ++connections[j];
                pictureBox.Image = bmp;
                pictureBox.Refresh();
                System.Threading.Thread.Sleep(speed);
            }
            graph = Graphics.FromImage(pictureBox.Image);
            var first = Array.FindIndex(connections, element => element == 1);
            var last = Array.FindLastIndex(connections, element => element == 1);
            graph.DrawLine(linePen, new Point(points[first].X, points[first].Y), new Point(points[last].X, points[last].Y));
            graph.DrawEllipse(circlePen, new Rectangle(new Point(points[first].X - 5, points[first].Y - 5), size));
            graph.DrawEllipse(circlePen, new Rectangle(new Point(points[last].X - 5, points[last].Y - 5), size));
            pictureBox.Image = bmp;
        }

        public void ManualDebug(ref PictureBox pictureBox, int i, int j, ref PersistentStack stack) 
        {
            Bitmap bmp = (Bitmap)pictureBox.Image;
            Graphics graph;
            Pen circlePen = new Pen(Program.circleColor, Program.circleSize);
            Pen linePen = new Pen(Program.lineColor, Program.lineSize);
            Size size = new Size(Program.circleSize, Program.circleSize);
            graph = Graphics.FromImage(bmp);
            int k = Convert.ToInt32(recovery[i, j]);
            int iCopy = i - 1;
            while (connections[k] > 1 && iCopy >= 0)
            {
                k = Convert.ToInt32(recovery[iCopy, j]);
                --iCopy;
            }
            graph.DrawLine(linePen, new Point(points[k].X, points[k].Y), new Point(points[j].X, points[j].Y));
            graph.DrawEllipse(circlePen, new Rectangle(new Point(points[k].X - 5, points[k].Y - 5), size));
            graph.DrawEllipse(circlePen, new Rectangle(new Point(points[j].X - 5, points[j].Y - 5), size));
            ++connections[k];
            ++connections[j];
            pictureBox.Image = bmp;
            pictureBox.Refresh();
            stack.Push(i, k, j);
        }

        public void LastManualDebug(ref PictureBox pictureBox, ref PersistentStack stack)
        {
            Bitmap bmp = (Bitmap)pictureBox.Image;
            Graphics graph = Graphics.FromImage(bmp);
            Pen circlePen = new Pen(Program.circleColor, Program.circleSize);
            Pen linePen = new Pen(Program.lineColor, Program.lineSize);
            Size size = new Size(Program.circleSize, Program.circleSize);
            var first = Array.FindIndex(connections, element => element == 1);
            var last = Array.FindLastIndex(connections, element => element == 1);
            graph.DrawLine(linePen, new Point(points[first].X, points[first].Y), new Point(points[last].X, points[last].Y));
            graph.DrawEllipse(circlePen, new Rectangle(new Point(points[first].X - 5, points[first].Y - 5), size));
            graph.DrawEllipse(circlePen, new Rectangle(new Point(points[last].X - 5, points[last].Y - 5), size));
            pictureBox.Image = bmp;
            ++connections[first];
            ++connections[last];
            stack.Push(stack.versions.Count, first, last);
        }

        public void ManualBackDebug(ref PictureBox pictureBox, ref PersistentStack stack)
        {
            Bitmap bmp = (Bitmap)pictureBox.Image;
            Graphics graph = Graphics.FromImage(bmp);
            Pen circlePen = new Pen(Program.circleColor, Program.circleSize);
            Pen linePen = new Pen(Color.White, Program.lineSize);
            Size size = new Size(Program.circleSize, Program.circleSize);
            int index = stack.versions.Count - 1;
            int k = stack.versions[index].firstPoint;
            int j = stack.versions[index].secondPoint;
            graph.DrawLine(linePen, new Point(points[k].X, points[k].Y), new Point(points[j].X, points[j].Y));
            graph.DrawEllipse(circlePen, new Rectangle(new Point(points[k].X - 5, points[k].Y - 5), size));
            graph.DrawEllipse(circlePen, new Rectangle(new Point(points[j].X - 5, points[j].Y - 5), size));
            --connections[k];
            --connections[j];
            stack.Pop(index);
            pictureBox.Image = bmp;
            pictureBox.Refresh();
        }
    }
}
