using System;
using System.Collections;

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
        /// and finally on its right descendants. In other words, 
        /// a node is always visited before any of its children.
        /// 
        /// Here recusion is used. When you first enter the procedure, 
        /// you print the root node's value. 
        /// Next, you recursively call the procedure to traverse  the left subtree.
        /// When you make this recursive call, the calling procedure's state is saved on the stack.
        /// When the recursive call returns, the calling procedure can pick up where
        /// it left off.
        /// 
        /// Complexity is O(n). Every node is examined once. 
        /// </summary>
        /// <param name="action"></param>
        public void PreorderTreversal(Action<T> action)
        {
            _PreorderTreversal(Root, action);
        }

        private void _PreorderTreversal(Node<T> root, Action<T> action)
        {
            if (root != null)
            {
                action(root.Value.Get());
                _PreorderTreversal(root.Left, action);
                _PreorderTreversal(root.Right, action);
            }
        }

        /// <summary>
        /// Because a stack is a LIFO data structure, push the right node onto 
        /// the stack firstm followed by the left node. 
        /// Instead of examining the left child explicitly, simply pop the first node
        /// from the stack, print its value, and push both of its children onto the stack
        /// in the correct order. If you start the procedure by pushing the root node
        /// onto the stack and then pop, print, and push as described.
        /// 
        /// Complexity is O(n). Each node is examined only once and pushed on the stack only once
        /// </summary>
        public void PreorderTreversalNonRecursively(Action<T> action)
        {
            Stack stack = new Stack();
            if (Root != null)
                stack.Push(Root);
            else
                return;

            while (stack.Count != 0)
            {
                Node<T> currNode = stack.Pop() as Node<T>;
                action(currNode.Value.Get());

                if (currNode.Right != null) stack.Push(currNode.Right);
                if (currNode.Left != null) stack.Push(currNode.Left);
            }
        }

        /// <summary>
        /// Inorder (Symmetric) - Performs the operation first on the node’s left descendants, then on the node 
        /// itself, and finally on its right descendants. In other words, 
        /// the left subtree is visited first, then the node itself, and then the node’s right subtree.
        /// 
        /// Complexity is O(n). Every node is examined once.
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
        /// 
        /// Complexity is O(n). Every node is examined once.
        /// </summary>
        /// <param name="action"></param>
        public void PostorderTreversal(Action<T> action)
        {
            _PostorderTreversal(Root, action);
        }

        private void _PostorderTreversal(Node<T> root, Action<T> action)
        {
            if (root != null)
            {
                _PostorderTreversal(root.Left, action);
                _PostorderTreversal(root.Right, action);
                action(root.Value.Get());
            }
        }

        /// <summary>
        /// Problem. Given the value of two nodes in a binary search tree, 
        /// find the lowest (nearest) common ancestor.
        /// You may assume that both values already exist in the tree.
        /// 
        /// Solution. When your target values are both less than the current node, you go left. 
        /// When they are both greater, you go right.The first node you encounter 
        /// that is between your target values is the lowest common ancestor.
        /// 
        /// Complexity is O(log(n)). You travel down a path to the lowest common ancestor. 
        /// Recall that traveling a path to any one node takes O(log(n)).
        /// </summary>
        public Node<T> GetLowestCommonAncestor(T value1, T value2)
        {
            Node<T> root = this.Root;
            while (root != null)
            {
                Interfaces.IComparable<T> value = root.Value;

                if (value.IsGraterThan(value1) && value.IsGraterThan(value2))
                    root = root.Left;
                else
                {
                    if (value.IsLessThan(value1) && value.IsLessThan(value2))
                        root = root.Right;
                    else
                        return root;
                }
            }
            return null; //only if empty tree
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

        /// <summary>
        /// The height of a tree (binary or not) is defined to be the maximum distance 
        /// from the root node to any leaf node
        /// </summary>
        /// <returns></returns>
        public int GetHeight()
        {
            throw new NotImplementedException();
        }

    }
}
