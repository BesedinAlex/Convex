package convex;

public class Convex {
    private Figure figure;
    private R2Point task;
    private Window window = new Window();
    public Convex() {
        figure = new Void();
    }
    public void add(R2Point point) {
        if (figure instanceof Polygon) {
            figure = figure.add(point, task);
            for (int i = 0; i < figure.task().size(); i++)
                window.addPolygon(figure.task().get(i));
        } else {
            figure = figure.add(point, task);
            window.addPoint(point);
            if (figure instanceof Segment || figure instanceof Polygon)
                window.repaint();
        }
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