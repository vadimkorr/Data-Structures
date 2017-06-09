using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Heaps are trees (usually binary trees) where (in a max-heap) each child of a node 
/// has a value less than or equal to the node’s own value. (In a min-heap, each child is 
/// greater than or equal to its parent.) 
/// Consequently, the root node always has the largest value in the tree, 
/// which means that you can 챂nd the maximum value in constant time: 
/// Simply return the root value.Insertion and deletion are still O(log(n)), 
/// but lookup becomes O(n). You cannot find the next higher node to a given node 
/// in O(log(n)) time or print out the nodes in sorted order in O(n) time as in a BST.
/// If extracting the max value needs to be fast, use a heap.
/// </summary>
namespace Heap
{
    class Heap
    {
        /// <summary>
        /// Start with the root, move left to right across the second level, 
        /// then move left to right across the third level, and so forth.
        /// You continue the search until either you have examined all the nodes 
        /// or you find the node you are searching for. 
        /// A BFS uses additional memory because it is necessary to track the child nodes 
        /// for all nodes on a given level while searching that level.
        /// </summary>
        public void BreadthFirstSearch()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// A depth-first search follows one branch of the tree down as many levels 
        /// as possible until the target node is found or the end is reached.
        /// When the search can’t go down any farther, it is continued 
        /// at the nearest ancestor with unexplored children.
        /// DFS has much lower memory requirements than BFS because it is not necessary 
        /// to store all the child pointers at each level.
        /// </summary>
        public void DepthFirstSearch()
        {
            throw new NotImplementedException();
        }
    }
}
