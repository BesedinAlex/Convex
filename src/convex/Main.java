package convex;

import convex.geometry.Point;

public class Main {
    public static void main(String[] args) throws Exception {
        Convex convex = new Convex();
        while (true) {
            convex.add(new Point());
            System.out.println("S = " + convex.area() + " , P = " + convex.perimeter() + " , task = " + convex.result());
        }
    }
}