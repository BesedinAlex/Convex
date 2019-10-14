using System;

namespace Convex.Geometry
{
    public class Point
    {
        public double X { get; }
        public double Y { get; }

        public Point()
        {
            Console.Write("Enter X: ");
            X = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Y: ");
            Y = Convert.ToDouble(Console.ReadLine());
        }

        public bool IsLighted(Point a, Point b)
        {
            var s = Basics.Area(a, b, this);
            return s < 0.0 || (s == 0 && !IsInside(a, b));
        }

        public bool IsInside(Point a, Point b)
        {
            return (a.X <= X && X <= b.X || a.X >= X && X >= b.X) && (a.Y <= Y && Y <= b.Y || a.Y >= Y && Y >= b.Y);
        }
    }
}
