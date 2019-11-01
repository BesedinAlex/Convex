using Convex.Figure;

namespace Convex
{
    internal class Convex
    {
        private IFigure figure;

        public Convex()
        {
            figure = new Void();
        }

        public void Add(Geometry.Point point)
        {
            figure = figure.Add(point);
        }

        public double Area
        {
            get => figure.Area;
        }

        public double Perimeter
        {
            get => figure.Perimeter;
        }
    }
}
