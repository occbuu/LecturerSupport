using System;

namespace DemoBST
{
    public class BinaryTreeNode<TNode> : IComparable<TNode> where TNode : IComparable<TNode>
    {
        public BinaryTreeNode(TNode value)
        {
            Value = value;
        }
        public BinaryTreeNode<TNode> Left { set; get; }
        public BinaryTreeNode<TNode> Right { set; get; }
        public TNode Value { set; get; }
        public int CompareTo(TNode other)
        {
            return Value.CompareTo(other);
        }
    }
}