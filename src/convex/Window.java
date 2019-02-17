package convex;

import javax.swing.*;
import java.awt.*;
import java.awt.geom.Path2D;
import java.util.ArrayList;

public class Window extends JFrame {
    private final Container pane = getContentPane();
    private final ArrayList<R2Point> points = new ArrayList<>();
    public Window() {
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setSize(800, 800);
        setResizable(false);
        pane.setLayout(new BorderLayout());
        JPanel renderPanel = new JPanel() {
            @Override public void paintComponent(Graphics g) {
                Graphics2D g2 = (Graphics2D) g;
                g2.translate(getWidth() / 2, getHeight() / 2);
                if (points.size() >= 2) {
                    g2.setColor(Color.red);
                    Path2D path = new Path2D.Double();
                    path.moveTo(points.get(0).getX(), -points.get(0).getY());
                    for (int i = 1; i < points.size(); i++)
                        path.lineTo(points.get(i).getX(), -points.get(i).getY());
                    path.closePath();
                    g2.draw(path);
                    g2.fill(path);
                }
            }
        };
        pane.add(renderPanel, BorderLayout.CENTER);
        setVisible(true);
    }
    public void addPoint(R2Point point) {
        points.add(point);
    }
    public void addPolygon(R2Point[] point) {
        pane.setLayout(new BorderLayout());
        JPanel renderPanel = new JPanel() {
            @Override public void paintComponent(Graphics g) {
                Graphics2D g2 = (Graphics2D) g;
                g2.translate(getWidth() / 2, getHeight() / 2);
                g2.setColor(Color.red);
                Path2D path = new Path2D.Double();
                path.moveTo(point[0].getX(), -point[0].getY());
                for (int i = 1; i < 3; i++)
                    path.lineTo(point[i].getX(), -point[i].getY());
                path.closePath();
                g2.draw(path);
                g2.fill(path);
            }
        };
        pane.add(renderPanel, BorderLayout.CENTER);
        setVisible(true);
        repaint();
    }
}