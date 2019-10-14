using Convex.Geometry;

namespace Convex.Figure
{
    public class Point: IFigure
    {
        private Geometry.Point p;

        public Point(Geometry.Point p)
        {
            this.p = p;
        }

        public IFigure Add(Geometry.Point q)
        {
            if (!Basics.Equals(p, q))
            {
                return new Segment(p, q);
            }
            else
            {
                return this;
            }
        }

        public double Perimeter
        {
            get => 0;
        }

        public double Area
        {
            get => 0;
        }
    }
}
