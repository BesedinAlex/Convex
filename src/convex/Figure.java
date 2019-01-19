package convex;

import java.util.ArrayList;

interface Figure {
    Figure add(R2Point point, R2Point task);
    double perimeter();
    double area();
    double result();
    ArrayList<R2Point[]> task();
}