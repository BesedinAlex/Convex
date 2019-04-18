namespace Convex.Figure
{
    interface IFigure
    {
        IFigure Add(Geometry.Point point, Geometry.Point squareDistance);
        double Perimeter();
        double Area();
        double SquareDistance();
    }
}
