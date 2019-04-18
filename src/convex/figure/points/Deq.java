package convex.figure.points;

import convex.geometry.Point;

public class Deq {
    private Point[] array = new Point[16];
    private int size = 0, head = 0, tail = array.length - 1;
    private int forward(int index) {
        return ++index < array.length ? index : 0;
    }
    private int backward(int index) {
        return --index >= 0 ? index : array.length - 1;
    }
    protected int length() {
        return size;
    }
    protected void pushFront(Point p) {
        array[head = backward(head)] = p;
        size += 1;
    }
    protected void pushBack(Point p) {
        array[tail = forward(tail)] = p;
        size += 1;
    }
    protected Point popFront() {
        Point p = front();
        head = forward(head);
        size -= 1;
        return p;
    }
    protected Point popBack() {
        Point p = back();
        tail = backward(tail);
        size -= 1;
        return p;
    }
    protected Point front() {
        return array[head];
    }
    protected Point back() {
        return array[tail];
    }
}