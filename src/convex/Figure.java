package convex;

interface Figure {
    public Figure add(R2Point point, R2Point task);
    public double perimeter();
    public double area();
    public double result();
    public R2Point task();
}
