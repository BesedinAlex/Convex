package convex;

import convex.geometry.Point;

class Convex {
    private convex.figure.Figure figure;
    private convex.geometry.Point task;
    Convex() throws Exception {
        System.out.println("Enter task point");
        task = new Point();
        System.out.println("Enter convex points");
        figure = new convex.figure.Void();
    }
    void add(Point point) {
        figure = figure.add(point, task);
    }
    double area() {
        return figure.area();
    }
    double perimeter() {
        return figure.perimeter();
    }
    double result() {
        return figure.result();
    }
}