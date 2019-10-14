namespace Convex.Figure
{
    public interface IFigure
    {
        IFigure Add(Geometry.Point point);
        double Perimeter { get; }
        double Area { get; }
    }
}
