package convex.geometry;

import java.util.Scanner;

public class Point {
    private double x, y;
    public Point() throws Exception {
        Scanner in = new Scanner(System.in);
        System.out.print("x -> ");
        x = Double.valueOf(in.nextLine());
        System.out.print("y -> ");
        y = Double.valueOf(in.nextLine());
    }
    public double getX() {
        return x;
    }
    public double getY() {
        return y;
    }
    public boolean light(Point a, Point b) {
        double s = Basics.area(a, b, this);
        return s < 0.0 || (s == 0 && ! inside(a, b));
    }
    public boolean inside(Point a, Point b) {
        return (a.x <= x && x <= b.x || a.x >= x && x >= b.x) && (a.y <= y && y <= b.y || a.y >= y && y >= b.y);
    }
}