using System;
using Convex.Geometry;

namespace Convex.Figure
{
    class Point: IFigure
    {
        private Geometry.Point point;
        private readonly Geometry.Point squareDistance;
        public Point(Geometry.Point point, Geometry.Point squareDistance)
        {
            this.point = point;
            this.squareDistance = squareDistance;
        }
        public IFigure Add(Geometry.Point point, Geometry.Point squareDistance)
        {
            if (!Basics.Equal(this.point, point))
                return new Segment(this.point, point, squareDistance);
            else
                return this;
        }
        public double Perimeter() =>
            0;
        public double Area() =>
            0;
        public double SquareDistance() =>
            System.Math.Pow(Basics.Distance(point, squareDistance), 2);
    }
}
