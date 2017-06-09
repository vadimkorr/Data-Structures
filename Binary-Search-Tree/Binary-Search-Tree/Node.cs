﻿using Binary_Search_Tree.Interfaces;

namespace Binary_Search_Tree
{
    public class Node<T>
    {
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
        public IComparable<T> Value { get; }
        public int Counter { get; private set; }

        public void Inc()
        {
            this.Counter++;
        }

        public Node(Node<T> left, Node<T> right, IComparable<T> value)
        {
            this.Left = left;
            this.Right = right;
            this.Value = value;
            this.Counter = 1;
        }
    }
}
