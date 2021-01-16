using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitonicTour
{
    class MyPoint
    {
        public int X;
        public int Y;

        public MyPoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Bitmap Draw(Bitmap bmp)
        {
            Graphics graph = Graphics.FromImage(bmp);
            Pen circlePen = new Pen(Program.circleColor, Program.circleSize);
            Size size = new Size(Program.circleSize, Program.circleSize);
            graph.DrawEllipse(circlePen, new Rectangle(new Point(X - 5, Y - 5), size));
            return bmp;
        }
    }
}
