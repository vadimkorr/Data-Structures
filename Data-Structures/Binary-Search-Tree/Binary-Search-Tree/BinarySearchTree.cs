using System;

namespace Binary_Search_Tree
{
    /// <summary>
    /// Trees are often used to store sorted or ordered data. 
    /// The most common way to store ordered data in a tree is to use a special tree 
    /// called abinary search tree(BST). In a BST, the value held by a node’s left child 
    /// is less than or equal to its own value, 
    /// and the value held by a node’s right child is greater than or equal to its value.
    /// In effect, the data in a BST is sorted by value: All the descendants 
    /// to the left of a node are less than or equal to the node, and 
    /// all the descendants to the right of the node are greater than or equal to the node.
    /// </summary> 
    public class BinarySearchTree<T>
    {
        public Node<T> Root { get; private set; }
        public bool InsertNodeRecursively(Interfaces.IComparable<T> value)
        {
            this.Root = _InsertNodeRecursively(this.Root, value);
            return true;
        }

        private Node<T> _InsertNodeRecursively(Node<T> root, Interfaces.IComparable<T> value)
        {
            //place for adding was found
            if (root == null)
                root = new Node<T>(null, null, value);
            else
                if (value.IsLessThan(root.Value.Get()))
                    root.Left = _InsertNodeRecursively(root.Left, value);
                else
                    if (value.IsGraterThan(root.Value.Get()))
                        root.Right = _InsertNodeRecursively(root.Right, value);
                    else
                        root.Inc();
            return root;
        }

        public Node<T> AddNonNodeRecursively(Node<T> root, Interfaces.IComparable<T> value)
        {
            throw new System.NotImplementedException();
        }


        /* ------------------------------------------------ */
        /* |                Traversals                    | */
        /* ------------------------------------------------ */

        //Depth-first search
        /// <summary>
        /// Preorder (Forward) — Performs the operation first on the node itself, then on its left descendants, 
        /// and finally on its right descendants. In other words,         /// a node is always visited before any of its children.
        /// </summary>
        /// <param name="action"></param>
        public void PreorderUreversal(Action<T> action)
        {
            _PreorderUreversal(Root, action);
        }

        private void _PreorderUreversal(Node<T> root, Action<T> action)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Inorder (Symmetric) - Performs the operation first on the node’s left descendants, then on the node 
        /// itself, and finally on its right descendants. In other words, 
        /// the left subtree is visited first, then the node itself, and then the node’s right subtree.
        /// </summary>
        /// <param name="action"></param>
        public void InorderTraversal(Action<T> action)
        {
            _InorderTraversal(Root, action);
        }

        private void _InorderTraversal(Node<T> root, Action<T> action)
        {
            if (root != null)
            {
                _InorderTraversal(root.Left, action);
                action(root.Value.Get());
                _InorderTraversal(root.Right, action);
            }
        }

        /// <summary>
        /// Postorder (Reversed) — Performs the operation first on the node’s left descendants, 
        /// then on the node’s right descendants, and finally on the node itself.
        /// In other words, a node is always visited after all its children.
        /// </summary>
        /// <param name="action"></param>
        public void PostorderUreversal(Action<T> action)
        {
            _PostorderUreversal(Root, action);
        }

        private void _PostorderUreversal(Node<T> root, Action<T> action)
        {
            throw new NotImplementedException();
        }




        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public Node<T> FindNodeNonRecursively(Node<T> root, T value)
        {
            while (root != null)
            {
                if (root.Value.IsEq(value))
                {
                    break;
                }
                if (root.Value.IsLessThan(value))
                {
                    root = root.Right;
                }
                else
                {
                    root = root.Left;
                }
            }
            return root;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="root"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public Node<T> FindNodeRecursively(Node<T> root, T value)
        {
            if (root == null)
            {
                return null;
            }
            if (root.Value.IsEq(value))
            {
                return root;
            }
            if (root.Value.IsLessThan(value))
            {
                return FindNodeRecursively(root.Right, value);
            }
            else
            {
                return FindNodeRecursively(root.Left, value);
            }
        }

    }
}
