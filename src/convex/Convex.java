package convex;

public class Convex {
    private Figure figure;
    private R2Point task;
    public Convex() {
        figure = new Void();
    }
    public void add(R2Point point) {
        figure = figure.add(point, task);
    }
    public double area() {
        return figure.area();
    }
    public double perimeter() {
        return figure.perimeter();
    }
    public double result() {
        return figure.result();
    }
    public void task(R2Point task) {
        this.task = task;
    }
}