using System;

namespace DemoQueue
{
    public class Stack<T>
    {
        LinkedList<T> _items = new LinkedList<T>();

        public void Push(T value)
        {
            _items.AddLast(value);
        }
        public T Pop()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty");
            }
            T result = _items.Tail.Value;
            _items.RemoveLast();
            return result;
        }
        public T Peek()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty");
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