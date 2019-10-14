namespace Convex.Figure
{
    public class Void: IFigure
    {
        public IFigure Add(Geometry.Point point)
        {
            return new Point(point);
        }

        public double Area
        {
            get => 0;
        }

        public double Perimeter
        {
            get => 0;
        }
    }
}
