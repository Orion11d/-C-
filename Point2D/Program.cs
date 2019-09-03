using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point2D
{

    class Point
    {
        public double X { set; get; } //авт. свойства
        public double Y { set; get; }// авт. свойства
        public Point (double x, double y) // конструктор класса
        {
            X = x;
            Y = y;
        }
        public double Distance ()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
        public static double Distance(Point p1, Point p2)
        {
            return Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(4, 5);
            Console.WriteLine(p1.Distance());
            Point p2 = new Point(3, 6);
            double k = Point.Distance(p1, p2);
            Console.WriteLine(k);
            Console.ReadKey(true);

        }
    }
}
