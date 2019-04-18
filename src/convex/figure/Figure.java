package convex.figure;

import convex.geometry.Point;

public interface Figure {
    Figure add(Point point, Point task);
    double perimeter();
    double area();
    double result(); // Sum of distances^2 from first entered point to all point of convex
}