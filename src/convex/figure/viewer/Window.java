package convex.figure.viewer;

import javax.swing.*;
import java.awt.*;
import java.awt.geom.Path2D;
import convex.geometry.Point;

public class Window extends JFrame {
    private final Container pane = getContentPane();
    public Window(Point[] points) {
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setSize(800, 800);
        setResizable(false);
        addPolygon(points);
        pane.setLayout(new BorderLayout());
    }
    public void addPolygon(Point[] point) {
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
            }
        };
        pane.add(renderPanel, BorderLayout.CENTER);
        setVisible(true);
        repaint();
    }
}