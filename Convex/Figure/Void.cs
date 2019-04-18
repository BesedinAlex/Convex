using System;

namespace Convex.Figure
{
    class Void: IFigure
    {
        public IFigure Add(Geometry.Point point, Geometry.Point squareDistance) =>
            new Point(point, squareDistance);
        public double Perimeter() => 
            0;
        public double Area() => 
            0;
        public double SquareDistance() => 
            0;
    }
}
