package convex.figure;

import convex.geometry.Basics;

public class Point implements Figure {
    private convex.geometry.Point p, task;
    Point(convex.geometry.Point p, convex.geometry.Point task) {
        this.p = p;
        this.task = task;
    }
    @Override
    public Figure add(convex.geometry.Point q, convex.geometry.Point task) {
        if (!Basics.equal(p, q))
            return new Segment(p, q, task);
        else return this;
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
        return Math.pow(Basics.distance(p, task), 2);
    }
}