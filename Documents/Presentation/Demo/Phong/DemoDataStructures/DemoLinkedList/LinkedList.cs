using System;
using System.Collections;
using System.Collections.Generic;

namespace DemoQueue
{
    public class LinkedList<T> : ICollection<T>
    {
        public LinkedListNode<T> _head { private set; get; }
        public LinkedListNode<T> _tail { private set; get; }
        public LinkedList()
        {
            _head = null;
            _tail = null;
            Count = 0;
        }
        public int Count
        {
            get;
            private set;
        }

        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(T item)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(item);
            if (_head == null)
            {
                _head = node;
                _tail = node;
            }
            else
            {
                _tail.Next = node;
                _tail = node;
            }
            Count++;
        }

        public void Clear()
        {
            _head = null;
            _tail = null;
            Count = 0;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetLinkedList()
        {
            LinkedListNode<T> current = _head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        public bool Remove(T item)
        {
            LinkedListNode<T> previous = null;
            LinkedListNode<T> current = _head;
            // 1: Empty list: Do nothing.
            // 2: Single node: Previous is null.
            // 3: Many nodes:
            // a: Node to remove is the first node.
            // b: Node to remove is the middle or last.
            while (current != null)
            {
                if (current.Value.Equals(item))
                {
                    // It's a node in the middle or end.
                    if (previous != null)
                    {
                        // Case 3b.
                        // Before: Head -> 3 -> 5 -> null
                        // After: Head -> 3 ------> null
                        previous.Next = current.Next;
                        // It was the end, so update _tail.
                        if (current.Next == null)
                        {
                            _tail = previous;
                        }
                    }
                    else
                    {
                        // Case 2 or 3a.
                        // Before: Head -> 3 -> 5
                        // After: Head ------> 5
                        // Head -> 3 -> null
                        // Head ------> null
                        _head = _head.Next;
                        // Is the list now empty?
                        if (_head == null)
                        {
                            _tail = null;
                        }
                    }
                    Count--;
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }

        public bool Contains(T value)
        {
            LinkedListNode<T> current = _head;
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    return true;
                }
                current = _head.Next;
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}