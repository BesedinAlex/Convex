using System;
using Convex.Geometry;

namespace Convex.Figure
{
    public class Polygon : Points.Deq, IFigure
    {
        private double perimeter;
        private double area;

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
            perimeter = Basics.DistanceBetween(a, b) + Basics.DistanceBetween(b, c) + Basics.DistanceBetween(c, a);
            area = Math.Abs(Basics.Area(a, b, c));
        }

        private void Grow(Geometry.Point a, Geometry.Point b, Geometry.Point t)
        {
            perimeter -= Basics.DistanceBetween(a, b);
            area += Math.Abs(Basics.Area(a, b, t));
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
                perimeter += Basics.DistanceBetween(Back, t) + Basics.DistanceBetween(t, Front);
                PushFront(t);
            }
            return this;
        }

        public double Perimeter
        {
            get => perimeter;
        }

        public double Area
        {
            get => area;
        }
    }
}
