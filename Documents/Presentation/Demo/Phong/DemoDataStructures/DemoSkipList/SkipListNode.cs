namespace DemoSkipList
{
    public class SkipListNode<T>
    {
        /// <summary>
        /// Creates a new node with the specified value
        /// at the indicated link height.
        /// </summary>
        public SkipListNode(T value, int height)
        {
            Value = value;
            Next = new SkipListNode<T>[height];
        }

        /// <summary>
        /// The array of links. The number of items
        /// is the height of the links.
        /// </summary>
        public SkipListNode<T>[] Next
        {
            get;
            private set;
        }

        /// <summary>
        /// The contained value.
        /// </summary>
        public T Value
        {
            get;
            private set;
        }
    }
}