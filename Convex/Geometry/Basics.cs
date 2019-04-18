using System;

namespace Convex.Geometry
{
    static class Basics
    {
        public static double Distance(Point a, Point b) =>
            System.Math.Sqrt((a.x - b.x) * (a.x - b.x) + (a.y - b.y) * (a.y - b.y));
        public static double Area(Point a, Point b, Point c) =>
            0.5 * ((a.x - c.x) * (b.y - c.y) - (a.y - c.y) * (b.x - c.x));
        public static bool Equal(Point a, Point b) =>
            a.x == b.x && a.y == b.y;
        public static bool IsTriangle(Point a, Point b, Point c) =>
            Area(a, b, c) != 0;
    }
}
