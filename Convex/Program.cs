using System;

namespace Convex
{
    class Program
    {
        static void Main(string[] args)
        {
            var convex = new Convex();
            while (true)
            {
                convex.Add(new Geometry.Point());
                Console.WriteLine($"S = {convex.Area}\nP = {convex.Perimeter}");
            }
        }
    }
}
