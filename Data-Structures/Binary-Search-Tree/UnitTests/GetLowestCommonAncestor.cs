using Microsoft.VisualStudio.TestTools.UnitTesting;
using Binary_Search_Tree;
using Binary_Search_Tree.ExtraModels;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class GetLowestCommonAncestor
    {
        BinarySearchTree<int> bst;

        public void PopulateTree()
        {
            List<int> input10Elements = new List<int>() { 5, 3, 8, 1, 4, 0, 2, 9, 7, 6 };
            foreach (int value in input10Elements)
                bst.InsertNode(new ComparableValue(value));
        }

        [TestInitialize]
        public void Init()
        {
            bst = Utils.GetNewTree();
        }

        [TestMethod]
        public void GetLowestCommonAncestorOfEmptyTree()
        {
            int value1 = 1;
            int value2 = 1;
            Node<int> actualResult = bst.GetLowestCommonAncestor(value1, value2);
            Node<int> expectedResult = null;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void GetLowestCommonAncestorWhereCommonIsRoot()
        {
            int value1 = 0;
            int value2 = 9;
            PopulateTree();
            Node<int> actualResult = bst.GetLowestCommonAncestor(value1, value2);
            int expectedResult = 5;

            Assert.AreEqual(expectedResult, actualResult.Value.Get());
        }

        [TestMethod]
        public void GetLowestCommonAncestorWhereCommonIsInTheLeftSide()
        {
            int value1 = 1;
            int value2 = 4;
            PopulateTree();
            Node<int> actualResult = bst.GetLowestCommonAncestor(value1, value2);
            int expectedResult = 3;

            Assert.AreEqual(expectedResult, actualResult.Value.Get());
        }

        [TestMethod]
        public void GetLowestCommonAncestorWhereCommonIsInTheRightSide()
        {
            int value1 = 9;
            int value2 = 6;
            PopulateTree();
            Node<int> actualResult = bst.GetLowestCommonAncestor(value1, value2);
            int expectedResult = 8;

            Assert.AreEqual(expectedResult, actualResult.Value.Get());
        }
    }
}
