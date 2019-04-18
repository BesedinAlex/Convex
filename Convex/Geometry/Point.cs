using System;

namespace Convex.Geometry
{
    class Point
    {
        public readonly double x, y;
        public Point()
        {
            try
            {
                Console.Write("Enter x: ");
                x = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter y: ");
                y = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Mistake was made\nX is now 0\nY is now 0");
                x = 0;
                y = 0;
            }
        }
        public bool Inside(Point a, Point b) =>
            (a.x <= x && x <= b.x || a.x >= x && x >= b.x) && (a.y <= y && y <= b.y || a.y >= y && y >= b.y);
        public bool Light(Point a, Point b)
        {
            var s = Basics.Area(a, b, this);
            return s < 0.0 || (s == 0 && !Inside(a, b));
        }
    }
}
