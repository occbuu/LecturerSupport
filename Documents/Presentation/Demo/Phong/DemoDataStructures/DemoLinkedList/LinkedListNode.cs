namespace DemoQueue
{
    public class LinkedListNode<T>
    {
        public T Value { set; get; }
        public LinkedListNode<T> Next { set; get; }
        public LinkedListNode(T value)
        {
            Value = value;
        }
    }
}