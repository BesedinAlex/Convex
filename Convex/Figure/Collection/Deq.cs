namespace Convex.Figure.Collection
{
    class Deq
    {
        private readonly Geometry.Point[] array;
        private int size, head, tail;
        public Deq()
        {
            array = new Geometry.Point[16];
            size = head = 0;
            tail = array.Length - 1;
        }
        private int Forward(int index) =>
            ++index < array.Length ? index : 0;
        private int Backward(int index) =>
            --index >= 0 ? index : array.Length - 1;
        public int Length() =>
            size;
        public void PushFront(Geometry.Point p)
        {
            array[head = Backward(head)] = p;
            size += 1;
        }
        public void PushBack(Geometry.Point p)
        {
            array[tail = Forward(tail)] = p;
            size += 1;
        }
        public Geometry.Point PopFront()
        {
            var p = Front();
            head = Forward(head);
            size -= 1;
            return p;
        }
        public Geometry.Point PopBack()
        {
            var p = Back();
            tail = Backward(tail);
            size -= 1;
            return p;
        }
        public Geometry.Point Front() =>
            array[head];
        public Geometry.Point Back() =>
            array[tail];
    }
}
