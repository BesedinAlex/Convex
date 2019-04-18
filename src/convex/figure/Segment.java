package convex.figure;

import convex.geometry.Point;
import convex.geometry.Basics;

public class Segment implements Figure {
    private Point p, q, task;
    Segment(Point p, Point q, Point task) {
        this.p = p; 
        this.q = q;
        this.task = task;
    }
    @Override
    public Figure add(Point r, Point task) {
        if (Basics.isTriangle(p, q, r))
            return new Polygon(p, q, r, task);
        if (q.inside(p, r))
            q = r;
        if (p.inside(r, q))
            p = r;
        return this;
    }
    @Override
    public double perimeter() {
        return 2 * Basics.distance(p, q);
    }
    @Override
    public double area() {
        return 0;
    }
    @Override
    public double result() {
        return Math.pow(Basics.distance(task, p), 2) + Math.pow(Basics.distance(task, q), 2);
    }
}