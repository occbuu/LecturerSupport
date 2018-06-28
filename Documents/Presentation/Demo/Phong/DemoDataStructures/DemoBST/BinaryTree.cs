using System;
using System.Collections;
using System.Collections.Generic;

namespace DemoBST
{
    public class BinaryTree<T> : IEnumerable<T> where T : IComparable<T>
    {
        private BinaryTreeNode<T> _head;
        private int _count;
        public void Add(T value) // Adds the provided value to the correct location within the tree.
        {
            // Case 1: The tree is empty. Allocate the head.
            if (_head == null)
            {
                _head = new BinaryTreeNode<T>(value);
            }
            // Case 2: The tree is not empty, so recursively
            // find the right location to insert the node.
            else
            {
                AddTo(_head, value);
            }
            _count++;
        }

        private void AddTo(BinaryTreeNode<T> node, T value)
        {
            // Case 1: Value is less than the current node value
            if (value.CompareTo(node.Value) < 0)
            {
                // If there is no left child, make this the new left,
                if (node.Left == null)
                {
                    node.Left = new BinaryTreeNode<T>(value);
                }
                else
                {
                    // else add it to the left node.
                    var left = node.Left;
                    AddTo(node.Left, value);
                }
            }
            // Case 2: Value is equal to or greater than the current value.
            else
            {
                // If there is no right, add it to the right,
                if (node.Right == null)
                {
                    node.Right = new BinaryTreeNode<T>(value);
                }
                else
                {
                    // else add it to the right node.
                    AddTo(node.Right, value);
                }
            }
        }

        public bool Contains(T value)
        {
            // Defer to the node search helper function.
            BinaryTreeNode<T> parent;
            return (FindWithParent(value, out parent) != null) ? true : false;
        }

        /// <summary>
        /// Finds and returns the first node containing the specified value. If the value
        /// is not found, it returns null. Also returns the parent of the found node (or null)
        /// which is used in Remove.
        /// </summary>
        private BinaryTreeNode<T> FindWithParent(T value, out BinaryTreeNode<T> parent)
        {
            // Now, try to find data in the tree.
            BinaryTreeNode<T> current = _head;
            parent = null;
            // While we don't have a match...
            while (current != null)
            {
                int result = current.CompareTo(value);
                if (result > 0)
                {
                    // If the value is less than current, go left.
                    parent = current;
                    current = current.Left;
                }
                else if (result < 0)
                {
                    // If the value is more than current, go right.
                    parent = current;
                    current = current.Right;
                }
                else
                {
                    // We have a match!
                    break;
                }
            }
            return current;
        }

        public bool Remove(T value) //Removes the first node found with the indicated value.
        {
            BinaryTreeNode<T> current, parent;
            // Find the node to remove.
            current = FindWithParent(value, out parent);
            if (current == null)
            {
                return false;
            }
            _count--;
            // Case 1: If current has no right child, current's left replaces current.
            if (current.Right == null)
            {
                if (parent == null)
                {
                    _head = current.Left;
                }
                else
                {
                    int result = parent.CompareTo(current.Value);
                    if (result > 0)
                    {
                        // If parent value is greater than current value,
                        // make the current left child a left child of parent.
                        parent.Left = current.Left;
                        var a = parent.Left;
                    }
                    else if (result < 0)
                    {
                        // If parent value is less than current value,
                        // make the current left child a right child of parent.
                        parent.Right = current.Left;
                        var a = parent.Right;
                    }
                }
            }
            // Case 2: If current's right child has no left child, current's right child
            // replaces current.
            else if (current.Right.Left == null)
            {
                current.Right.Left = current.Left;
                if (parent == null)
                {
                    _head = current.Right;
                }
                else
                {
                    int result = parent.CompareTo(current.Value);
                    if (result > 0)
                    {
                        // If parent value is greater than current value,
                        // make the current right child a left child of parent.
                        parent.Left = current.Right;
                        var a = parent.Right;
                    }
                    else if (result < 0)
                    {
                        // If parent value is less than current value,
                        // make the current right child a right child of parent.
                        var a = parent.Right;
                        parent.Right = current.Right;
                    }
                }
            }
            // Case 3: If current's right child has a left child, rep
            // right child's left-most child.
            else
            {
                // Find the right's left-most child.
                BinaryTreeNode<T> leftmost = current.Right.Left;
                BinaryTreeNode<T> leftmostParent = current.Right;
                while (leftmost.Left != null)
                {
                    leftmostParent = leftmost;
                    leftmost = leftmost.Left;
                }
                // The parent's left subtree becomes the leftmost's right subtree.
                leftmostParent.Left = leftmost.Right;
                // Assign leftmost's left and right to current's left and right children.
                leftmost.Left = current.Left;
                leftmost.Right = current.Right;
                if (parent == null)
                {
                    _head = leftmost;
                }
                else
                {
                    int result = parent.CompareTo(current.Value);
                    if (result > 0)
                    {
                        // If parent value is greater than current value,
                        // make leftmost the parent's left child.
                        parent.Left = leftmost;
                    }
                    else if (result < 0)
                    {
                        // If parent value is less than current value,
                        // make leftmost the parent's right child.
                        parent.Right = leftmost;
                    }
                }
            }
            return true;
        }

        public void PreOrderTraversal(Action<T> action)
        {
            throw new NotImplementedException();
        }

        public void PostOrderTraversal(Action<T> action)
        {
            throw new NotImplementedException();
        }

        public void InOrderTraversal(Action<T> action)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            _head = null;
            _count = 0;
        }

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}