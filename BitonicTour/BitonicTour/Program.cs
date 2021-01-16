using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BitonicTour
{
    static class Program
    {
        static internal Color circleColor = Color.Red;
        static internal Color lineColor = Color.Red;
        static internal int circleSize = 10;
        static internal int lineSize = 5;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
