using System;
using Convex.Geometry;

namespace Convex.Figure
{
    class Segment: IFigure
    {
        private Geometry.Point p, q;
        private readonly Geometry.Point squareDistance;
        public Segment(Geometry.Point p, Geometry.Point q, Geometry.Point squareDistance)
        {
            this.p = p;
            this.q = q;
            this.squareDistance = squareDistance;
        }
        public IFigure Add(Geometry.Point r, Geometry.Point task)
        {
            if (Basics.IsTriangle(p, q, r))
                return new Polygon(p, q, r, task);
            if (q.Inside(p, r))
                q = r;
            if (p.Inside(r, q))
                p = r;
            return this;
        }
        public double Perimeter() =>
            2 * Basics.Distance(p, q);
        public double Area() =>
            0;
        public double SquareDistance() =>
            Math.Pow(Basics.Distance(squareDistance, p), 2) + Math.Pow(Basics.Distance(squareDistance, q), 2);
    }
}
