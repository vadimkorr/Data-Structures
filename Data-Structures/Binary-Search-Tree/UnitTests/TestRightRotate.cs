using Microsoft.VisualStudio.TestTools.UnitTesting;
using Binary_Search_Tree;
using Binary_Search_Tree.ExtraModels;
using System.Collections.Generic;
using System;

namespace UnitTests
{
    [TestClass]
    public class TestRightRotate
    {
        BinarySearchTree<int> bst;

        [TestInitialize]
        public void Init()
        {
            bst = Utils.GetNewTree();
        }

        [TestMethod]
        public void RightRotateUnbalancedTree()
        {
            //input unbalanced tree
            List<int> input = new List<int> { 6, 7, 4, 5, 2, 1, 3 };
            Utils.PopulateTree(input, bst);

            //rotate right
            bst.Root = bst.RightRotate();

            //preorder traverse and check
            List<int> expected = new List<int>() { 4, 2, 1, 3, 6, 5, 7 };
            int index = 0;
            bst.PreorderTreversal((value) => {
                Console.Write(value.Get() + " ");
                Assert.AreEqual(value.Get(), expected[index++]);
            });            
        }

        [TestMethod]
        public void RightRotateUnbalancedTree3Nodes()
        {
            //input unbalanced tree
            List<int> input = new List<int> { 2, 1, 3 };
            Utils.PopulateTree(input, bst);

            //rotate right
            bst.Root = bst.RightRotate();

            //preorder traverse and check
            List<int> expected = new List<int>() { 1, 2, 3 };
            int index = 0;
            bst.PreorderTreversal((value) => {
                Console.Write(value.Get() + " ");
                Assert.AreEqual(value.Get(), expected[index++]);
            });
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), "Root has no left node")]
        public void RightRotateUnbalancedTreeWithoutLeftNode()
        {
            //input unbalanced tree
            List<int> input = new List<int> { 1 };
            Utils.PopulateTree(input, bst);

            //rotate right
            bst.Root = bst.RightRotate();
        }

        [TestMethod]
        public void RightRotateUnbalancedTree2NodesWithLeftNode()
        {
            //input unbalanced tree
            List<int> input = new List<int> { 2, 1 };
            Utils.PopulateTree(input, bst);

            //rotate right
            bst.Root = bst.RightRotate();

            //preorder traverse and check
            List<int> expected = new List<int>() { 1, 2 };
            int index = 0;
            bst.PreorderTreversal((value) => {
                Console.Write(value.Get() + " ");
                Assert.AreEqual(value.Get(), expected[index++]);
            });
        }
    }
}
