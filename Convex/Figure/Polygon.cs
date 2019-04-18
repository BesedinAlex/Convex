using System;
using Convex.Geometry;

namespace Convex.Figure
{
    class Polygon : Collection.Deq, IFigure
    {
        private double s, p, squareDistance;
        private readonly Geometry.Point squareDistancePoint;
        public Polygon(Geometry.Point a, Geometry.Point b, Geometry.Point c, Geometry.Point squareDistancePoint)
        {
            PushFront(b);
            if (b.Light(a, c))
            {
                PushFront(a);
                PushBack(c);
            }
            else
            {
                PushFront(c);
                PushBack(a);
            }
            p = Basics.Distance(a, b) + Basics.Distance(b, c) + Basics.Distance(c, a);
            s = Math.Abs(Basics.Area(a, b, c));
            this.squareDistance = 
                Math.Pow(Basics.Distance(squareDistancePoint, a), 2) + Math.Pow(Basics.Distance(squareDistancePoint, b), 2) + Math.Pow(Basics.Distance(squareDistancePoint, c), 2);
            this.squareDistancePoint = squareDistancePoint;
        }
        private void Grow(Geometry.Point a, Geometry.Point b, Geometry.Point t)
        {
            p -= Basics.Distance(a, b);
            s += Math.Abs(Basics.Area(a, b, t));
        }
        public IFigure Add(Geometry.Point point, Geometry.Point squareDistance)
        {
            int i;
            for (i = Length(); i > 0 && !point.Light(Back(), Front()); i--)
                PushBack(PopFront());
            if (i > 0)
            {
                Geometry.Point x;
                Grow(Back(), Front(), point);
                this.squareDistance += Math.Pow(Basics.Distance(squareDistancePoint, point), 2);
                for (x = PopFront(); point.Light(x, Front()); x = PopFront())
                {
                    Grow(x, Front(), point);
                    this.squareDistance -= Math.Pow(Basics.Distance(squareDistancePoint, x), 2);
                }
                PushFront(x);
                for (x = PopBack(); point.Light(Back(), x); x = PopBack())
                {
                    Grow(Back(), x, point);
                    this.squareDistance -= Math.Pow(Basics.Distance(squareDistancePoint, x), 2);
                }
                PushBack(x);
                p += Basics.Distance(Back(), point) + Basics.Distance(point, Front());
                PushFront(point);
            }
            return this;
        }
        public double Perimeter() =>
            p;
        public double Area() =>
            s;
        public double SquareDistance() =>
            squareDistance;
    }
}
