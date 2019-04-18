using System;
using Convex.Geometry;

namespace Convex
{
    class Convex
    {
        private Figure.IFigure figure;
        private readonly Point squareDistance;
        public Convex(Point squareDistance)
        {
            System.Console.WriteLine("Now enter convex points");
            this.squareDistance = squareDistance; 
            figure = new Figure.Void();
        }
        public void Add(Point point) =>
            figure = figure.Add(point, squareDistance);
        public double Area() =>
            figure.Area();
        public double Perimeter() =>
            figure.Perimeter();
        public double SquareDistance() =>
            figure.SquareDistance();
    }
}
