package convex.geometry;

public class Basics {
    public static double distance(Point a, Point b) {
        return Math.sqrt((a.getX() - b.getX()) * (a.getX() - b.getX()) + (a.getY() - b.getY()) * (a.getY() - b.getY()));
    }
    public static double area(Point a, Point b, Point c) {
        return 0.5 * ((a.getX() - c.getX()) * (b.getY() - c.getY()) - (a.getY() - c.getY()) * (b.getX() - c.getX()));
    }
    public static boolean equal(Point a, Point b) {
        return a.getX() == b.getX() && a.getY() == b.getY();
    }
    public static boolean isTriangle(Point a, Point b, Point c) {
        return area(a, b, c) != 0;
    }

}
