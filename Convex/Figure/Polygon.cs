using System;
using Convex.Geometry;

namespace Convex.Figure
{
    public class Polygon : Points.Deq, IFigure
    {
        public double Perimeter { get; private set; }
        public double Area { get; private set; }

        public Polygon(Geometry.Point a, Geometry.Point b, Geometry.Point c)
        {
            PushFront(b);
            if (b.IsLighted(a, c))
            {
                PushFront(a);
                PushBack(c);
            }
            else
            {
                PushFront(c);
                PushBack(a);
            }
            Perimeter = Basics.DistanceBetween(a, b) + Basics.DistanceBetween(b, c) + Basics.DistanceBetween(c, a);
            Area = Math.Abs(Basics.Area(a, b, c));
        }

        private void Grow(Geometry.Point a, Geometry.Point b, Geometry.Point t)
        {
            Perimeter -= Basics.DistanceBetween(a, b);
            Area += Math.Abs(Basics.Area(a, b, t));
        }

        public IFigure Add(Geometry.Point t)
        {
            int i;
            for (i = Length; i > 0 && !t.IsLighted(Back, Front); i--)
            {
                PushBack(PopFront);
            }
            if (i > 0)
            {
                Geometry.Point x;
                Grow(Back, Front, t);
                for (x = PopFront; t.IsLighted(x, Front); x = PopFront)
                {
                    Grow(x, Front, t);
                }
                PushFront(x);
                for (x = PopBack; t.IsLighted(Back, x); x = PopBack)
                {
                    Grow(Back, x, t);
                }
                PushBack(x);
                Perimeter += Basics.DistanceBetween(Back, t) + Basics.DistanceBetween(t, Front);
                PushFront(t);
            }
            return this;
        }

        
    }
}
