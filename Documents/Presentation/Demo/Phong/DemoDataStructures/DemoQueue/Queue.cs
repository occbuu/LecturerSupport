using System;

namespace DemoQueue
{
    public class Queue<T>
    {
        LinkedList<T> _items = new LinkedList<T>();
        public void Enqueue(T value)
        {
            _items.AddLast(value);
        }
        public T Dequeue()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty");
            }
            T first = _items.Head.Value;
            _items.RemoveFirst();
            return first;
        }
        public T Peek()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty");
            }
            return _items.Tail.Value;
        }
        public int Count
        {
            get
            {
                return _items.Count;
            }
        }
    }
}