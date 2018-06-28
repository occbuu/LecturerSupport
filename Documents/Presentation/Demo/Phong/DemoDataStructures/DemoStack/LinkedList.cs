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
            AddLast(item);
        }

        public LinkedListNode<T> Head
        {
            get
            {
                return _head;
            }
        }

        public LinkedListNode<T> Tail
        {
            get
            {
                return _tail;
            }
        }

        public void AddFirst(T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(value);
            // Save off the head node so we don't lose it.
            LinkedListNode<T> temp = _head;
            // Point head to the new node.
            _head = node;
            // Insert the rest of the list behind head.
            _head.Next = temp;
            if (Count == 0)
            {
                // If the list was empty then head and tail should
                // both point to the new node.
                _tail = _head;
            }
            else
            {
                // Before: head -------> 5 <-> 7 -> null
                // After: head -> 3 <-> 5 <-> 7 -> null
                temp.Previous = _head;
            }
            Count++;
        }

        public void AddLast(T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(value);
            if (Count == 0)
            {
                _head = node;
            }
            else
            {
                _tail.Next = node;
                // Before: Head -> 3 <-> 5 -> null
                // After: Head -> 3 <-> 5 <-> 7 -> null
                // 7.Previous = 5
                node.Previous = _tail;
            }
            _tail = node;
            Count++;
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
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
                // Head -> 3 -> 5 -> 7 -> null
                // Head -> 3 ------> 7 -> null
                if (current.Value.Equals(item))
                {
                    // It's a node in the middle or end.
                    if (previous != null)
                    {
                        // Case 3b.
                        previous.Next = current.Next;
                        // It was the end, so update _tail.
                        if (current.Next == null)
                        {
                            _tail = previous;
                        }
                        else
                        {
                            // Before: Head -> 3 <-> 5 <-> 7 -> null
                            // After: Head -> 3 <-------> 7 -> null
                            // previous = 3
                            // current = 5
                            // current.Next = 7
                            // So... 7.Previous = 3
                            current.Next.Previous = previous;
                        }
                        Count--;
                    }
                    else
                    {
                        // Case 2 or 3a.
                        RemoveFirst();
                    }
                    return true;
                }
                previous = current;
                current = current.Next;
            }
            return false;
        }

        public void RemoveFirst()
        {
            if (Count != 0)
            {
                // Before: Head -> 3 <-> 5
                // After: Head -------> 5
                // Head -> 3 -> null
                // Head ------> null
                _head = _head.Next;
                Count--;
                if (Count == 0)
                {
                    _tail = null;
                }
                else
                {
                    // 5.Previous was 3; now it is null.
                    _head.Previous = null;
                }
            }
        }

        public void RemoveLast()
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    _head = null;
                    _tail = null;
                }
                else
                {
                    // Before: Head --> 3 --> 5 --> 7
                    // Tail = 7
                    // After: Head --> 3 --> 5 --> null
                    // Tail = 5
                    // Null out 5's Next property.
                    _tail.Previous.Next = null;
                    _tail = _tail.Previous;
                }
                Count--;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}