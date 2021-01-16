using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitonicTour
{
    class BitonicTour
    {
        private const double ZERO = 0;
        private int n;
        private double[,] dist;
        private List<MyPoint> points;
        public double optimalTour;

        public BitonicTour(List<MyPoint> points)
        {
            this.points = points;
            this.n = points.Count;
            dist = CreateMatrix();
        }

        public Bitmap BitonicTourDraw(Bitmap bmp)
        {
            Graphics graph = Graphics.FromImage(bmp);
            Pen circlePen = new Pen(Program.circleColor, Program.circleSize);
            Pen linePen = new Pen(Program.lineColor, Program.lineSize);
            Size size = new Size(Program.circleSize, Program.circleSize);
            double[,] recovery = SolveBitonic();
            int[] connections = new int[n];
            for (int i = 0, j = 1; i < n - 1; ++i, ++j)
            {
                int k = Convert.ToInt32(recovery[i, j]);
                int iCopy = i - 1;
                while(connections[k] > 1 && iCopy >= 0)
                {
                    k = Convert.ToInt32(recovery[iCopy, j]);
                    --iCopy;
                }
                graph.DrawLine(linePen, new Point(points[k].X, points[k].Y), new Point(points[j].X, points[j].Y));
                graph.DrawEllipse(circlePen, new Rectangle(new Point(points[k].X - 5, points[k].Y - 5), size));
                graph.DrawEllipse(circlePen, new Rectangle(new Point(points[j].X - 5, points[j].Y - 5), size));
                ++connections[k];
                ++connections[j];
                
            }
            var first = Array.FindIndex(connections, element => element == 1);
            var last = Array.FindLastIndex(connections, element => element == 1);
            graph.DrawLine(linePen, new Point(points[first].X, points[first].Y), new Point(points[last].X, points[last].Y));
            graph.DrawEllipse(circlePen, new Rectangle(new Point(points[first].X - 5, points[first].Y - 5), size));
            graph.DrawEllipse(circlePen, new Rectangle(new Point(points[last].X - 5, points[last].Y - 5), size));
            return bmp;
        }

        public double[,] GetRecovery()
        {
            double[,] recovery = SolveBitonic();
            return recovery;
        }

        private double[,] CreateMatrix()
        {
            dist = new double[n, n];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    dist[i, j] = Math.Sqrt(Math.Pow((points[i].X - points[j].X), 2) +
                        Math.Pow((points[i].Y - points[j].Y), 2));
                }
            }
            return dist;
        }
        public double[,] SolveBitonic()
        {
            const double inf = 1 / ZERO;
            double[,] res = new double[n, n];
            double[,] prev = new double[n, n];
            for (int i = 0; i < n - 1; ++i)
            {
                for (int j = 1; j < n; ++j)
                {
                    if (i == j - 1)
                    {
                        if (i == 0)
                        {
                            res[i, j] = dist[i, j];
                            prev[i, j] = i;
                        }
                        else
                        {
                            res[i, j] = inf;
                            for (int k = 0; k < i; ++k)
                            {
                                double new_length = res[k, i] + dist[k, j];
                                if (new_length < res[i, j])
                                {
                                    res[i, j] = new_length;
                                    prev[i, j] = k;
                                }
                            }
                        }
                    }
                    else
                    {
                        res[i, j] = res[i, j - 1] + dist[j - 1, j];
                        prev[i, j] = j - 1;
                    }
                }
            }
            optimalTour = res[n - 2, n-1] + dist[n - 2, n-1];
            //return res; // вернуть матрицу расстояний
            return prev; // вернуть матрицу для восстановления путей
        }
    }
}
