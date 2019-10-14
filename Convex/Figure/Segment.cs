using Convex.Geometry;

namespace Convex.Figure
{
    public class Segment: IFigure
    {
        private Geometry.Point p;
        private Geometry.Point q;

        public Segment(Geometry.Point p, Geometry.Point q)
        {
            this.p = p;
            this.q = q;
        }

        public IFigure Add(Geometry.Point r)
        {
            if (Basics.IsTriangle(p, q, r))
            {
                return new Polygon(p, q, r);
            }
            if (q.IsInside(p, r))
            {
                q = r;
            }
            if (p.IsInside(r, q))
            {
                p = r;
            }
            return this;
        }

        public double Perimeter
        {
            get => 2 * Basics.DistanceBetween(p, q);
        }

        public double Area
        {
            get => 0;
        }
    }
}
