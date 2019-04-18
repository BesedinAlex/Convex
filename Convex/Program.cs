using System;

namespace Convex
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter point to check square distance");
            var convex = new Convex(new Geometry.Point());
            while (true)
            {
                convex.Add(new Geometry.Point());
                Console.WriteLine("S = " + convex.Area() + " , P = " + convex.Perimeter() + " , square distance = " + convex.SquareDistance());
            }
        }
    }
}