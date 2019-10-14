using System;

namespace Convex.Geometry
{
    public static class Basics
    {
        public static double DistanceBetween(Point a, Point b)
        {
            return Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
        }

        public static double Area(Point a, Point b, Point c)
        {
            return 0.5 * ((a.X - c.X) * (b.Y - c.Y) - (a.Y - c.Y) * (b.X - c.X));
        }

        public static bool Equals(Point a, Point b)
        {
            return a.X == b.X && a.Y == b.Y;
        }

        public static bool IsTriangle(Point a, Point b, Point c)
        {
            return Area(a, b, c) != 0;
        }
    }
}
