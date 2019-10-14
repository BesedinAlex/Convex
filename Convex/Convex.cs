using Convex.Figure;

namespace Convex
{
    internal class Convex
    {
        private IFigure Figure { get; set; }

        public Convex()
        {
            Figure = new Void();
        }

        public void Add(Geometry.Point point)
        {
            Figure = Figure.Add(point);
        }

        public double Area
        {
            get => Figure.Area;
        }

        public double Perimeter
        {
            get => Figure.Perimeter;
        }
    }
}
