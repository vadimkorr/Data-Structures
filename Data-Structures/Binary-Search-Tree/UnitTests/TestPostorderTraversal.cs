using Binary_Search_Tree;
using Binary_Search_Tree.ExtraModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class TestPostorderTraversal
    {
        BinarySearchTree<int> bst;

        [TestInitialize]
        public void Init()
        {
            bst = Utils.GetNewTree();
        }

        [TestMethod]
        public void PostorderTraverse3Elements()
        {
            List<int> expectedOutput = new List<int>() { 10, 30, 20 };

            //add elements to the tree
            List<int> input3Elements = new List<int>() { 20, 30, 10 };
            foreach (int value in input3Elements)
                bst.InsertNode(new ComparableValue(value));

            //traverse
            List<int> actualOutput = new List<int>();
            bst.PostorderTreversal((value) => {
                Console.Write(value + " ");
                actualOutput.Add(value.Get());
            });

            //check
            Assert.IsTrue(actualOutput.Count > 0);
            for (int i = 0; i < input3Elements.Count; i++)
                Assert.AreEqual(expectedOutput[i], actualOutput[i]);           
        }

        [TestMethod]
        public void PostorderTraverse10Elements()
        {
            List<int> expectedOutput10Elements = new List<int>() { 0, 2, 1, 4, 3, 6, 7, 9, 8, 5 };

            //add elements to the tree
            List<int> input10Elements = new List<int>() { 5, 3, 8, 1, 4, 0, 2, 9, 7, 6 };
            foreach (int value in input10Elements)
                bst.InsertNode(new ComparableValue(value));

            //traverse
            List<int> actualOutput = new List<int>();
            bst.PostorderTreversal((value) => {
                Console.Write(value + " ");
                actualOutput.Add(value.Get());
            });

            //check
            Assert.IsTrue(actualOutput.Count > 0);
            for (int i = 0; i < input10Elements.Count; i++)
                Assert.AreEqual(expectedOutput10Elements[i], actualOutput[i]);
        }

        [TestMethod]
        public void PostorderTraverse0Elements()
        {
            List<int> input0Elements = new List<int>() { };
            List<int> expectedOutput0Elements = new List<int>() { };

            //add elements to the tree
            foreach (int value in input0Elements)
                bst.InsertNode(new ComparableValue(value));

            //traverse
            List<int> actualOutput = new List<int>();
            bst.PostorderTreversal((value) => {
                Console.Write(value + " ");
                actualOutput.Add(value.Get());
            });

            //check
            Assert.IsTrue(actualOutput.Count == 0);
            for (int i = 0; i < input0Elements.Count; i++)
                Assert.AreEqual(expectedOutput0Elements[i], actualOutput[i]);
        }
    }
}
