namespace Convex.Figure.Points
{
    public class Deq
    {
        public int Length { get; private set; }
        private readonly Geometry.Point[] points;
        private int head;
        private int tail;

        public Deq()
        {
            Length = 0;
            points = new Geometry.Point[16];
            head = 0;
            tail = points.Length - 1;
        }

        public Geometry.Point Front
        {
            get => points[head];
        }

        public Geometry.Point Back
        {
            get => points[tail];
        }

        public void PushFront(Geometry.Point point)
        {
            points[head = Backward(head)] = point;
            Length += 1;
        }

        public void PushBack(Geometry.Point point)
        {
            points[tail = Forward(tail)] = point;
            Length += 1;
        }

        public Geometry.Point PopFront
        {
            get
            {
                var point = Front;
                head = Forward(head);
                Length -= 1;
                return point;
            }
        }

        public Geometry.Point PopBack
        {
            get
            {
                var point = Back;
                tail = Backward(tail);
                Length -= 1;
                return point;
            }
        }

        private int Forward(int index)
        {
            return ++index < points.Length ? index : 0;
        }

        private int Backward(int index)
        {
            return --index >= 0 ? index : points.Length - 1;
        }
    }
}
