package convex.figure;

import convex.geometry.Point;

public class Void implements Figure {
    public Figure add(Point p, Point task) {
        return new convex.figure.Point(p, task);
    }
    @Override
    public double perimeter() {
        return 0;
    }
    @Override
    public double area() {
        return 0;
    }
    @Override
    public double result() {
        return 0;
    }
}