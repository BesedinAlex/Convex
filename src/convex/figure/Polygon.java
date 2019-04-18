package convex.figure;

import convex.figure.points.Deq;
import convex.figure.viewer.Window;
import convex.geometry.Basics;
import convex.geometry.Point;

public class Polygon extends Deq implements Figure {
    private double s, p, task;
    private Point taskPoint;
    private Window window;
    Polygon(Point a, Point b, Point c, Point taskPoint) {
        pushFront(b);
        if (b.light(a, c)) {
            pushFront(a);
            pushBack(c);
        } else {
            pushFront(c);
            pushBack(a);
        }
        p = Basics.distance(a, b) + Basics.distance(b, c) + Basics.distance(c, a);
        s = Math.abs(Basics.area(a, b, c));
        task = Math.pow(Basics.distance(taskPoint, a), 2) + Math.pow(Basics.distance(taskPoint, b), 2) + Math.pow(Basics.distance(taskPoint, c), 2);
        this.taskPoint = taskPoint;
//        viewerPoints = new ArrayList<>();
        Point[] points = {a, b, c};
        window = new Window(points);
    }
    private void grow(Point a, Point b, Point t) {
        p -= Basics.distance(a, b);
        s += Math.abs(Basics.area(a, b, t));
        Point[] points = {a, b, t};
        window.addPolygon(points);
    }
    @Override
    public Figure add(Point t, Point task) {
        int i;
        for (i = length(); i > 0 && !t.light(back(), front()); i--) pushBack(popFront());
        if (i > 0) {
            Point x;
            grow(back(), front(), t);
            this.task += Math.pow(Basics.distance(taskPoint, t), 2);
            for (x = popFront(); t.light(x, front()); x = popFront()) {
                grow(x, front(), t);
                this.task -= Math.pow(Basics.distance(taskPoint, x), 2);
            }
            pushFront(x);
            for (x = popBack(); t.light(back(), x); x = popBack()) {
                grow(back(), x, t);
                this.task -= Math.pow(Basics.distance(taskPoint, x), 2);
            }
            pushBack(x);
            p += Basics.distance(back(), t) + Basics.distance(t, front());
            pushFront(t);
        }
        return this;
    }
    @Override
    public double perimeter() {
        return p;
    }
    @Override
    public double area() {
        return s;
    }
    @Override
    public double result() {
        return task;
    }
}