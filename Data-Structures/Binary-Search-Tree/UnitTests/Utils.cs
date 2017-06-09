using Binary_Search_Tree;
using Binary_Search_Tree.ExtraModels;
using System.Collections.Generic;

namespace UnitTests
{
    class Utils
    {
        /*private static ComparableValue _NodeValueBuilderDelegate(int value)
        {
            return new ComparableValue(value);
        }*/

        public static BinarySearchTree<int> GetNewTree()
        {
            return new BinarySearchTree<int>(/*_NodeValueBuilderDelegate*/);
        }

        public static void PopulateTree(List<int> input, BinarySearchTree<int> bst)
        {
            foreach (int value in input)
                bst.InsertNode(new ComparableValue(value));
        }
    }
}
