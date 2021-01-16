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
    public partial class EditSize : Form
    {
        private string mode;
        public EditSize(string mode)
        {
            InitializeComponent();
            if(mode == "circle")
            {
                label1.Text = "Размер вершин";
                textBox1.Text = Program.circleSize.ToString();
            }
            else if(mode == "line")
            {
                label1.Text = "Размер линий";
                textBox1.Text = Program.lineSize.ToString();
            }
            this.mode = mode;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 0)
            {
                MessageBox.Show("Заполните поле для внесения изменения!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(mode == "circle")
            {
                Program.circleSize = Convert.ToInt32(textBox1.Text);
            }
            else if(mode == "line")
            {
                Program.lineSize = Convert.ToInt32(textBox1.Text);
            }
            Close();
            MessageBox.Show("Изменения сохранены!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
