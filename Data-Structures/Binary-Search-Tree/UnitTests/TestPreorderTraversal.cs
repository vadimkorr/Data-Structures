using Binary_Search_Tree;
using Binary_Search_Tree.ExtraModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class TestPreorderTraversal
    {
        BinarySearchTree<int> bst;

        [TestInitialize]
        public void Init()
        {
            bst = Utils.GetNewTree();
        }

        //0 elements
        static List<int> input0Elements = new List<int>() { };
        static List<int> expectedOutput0Elements = new List<int>() { };

        //3 elements
        static List<int> input3Elements = new List<int>() { 20, 30, 10 };
        static List<int> expectedOutput3Elements = new List<int>() { 20, 10, 30 };

        //10 elements
        static List<int> expectedOutput10Elements = new List<int>() { 5, 3, 1, 0, 2, 4, 8, 7, 6, 9 };
        static List<int> input10Elements = new List<int>() { 5, 3, 8, 1, 4, 0, 2, 9, 7, 6 };

        private void _PopulateTree(List<int> input)
        {
            foreach (int value in input)
                bst.InsertNode(new ComparableValue(value));
        }

        [TestMethod]
        public void PreorderTraverse0ElementsRecursively()
        {
            //add elements to the tree
            _PopulateTree(input0Elements);

            //traverse
            List<int> actualOutput = new List<int>();
            bst.PreorderTreversal((value) => {
                Console.Write(value + " ");
                actualOutput.Add(value.Get());
            });

            //check
            Assert.IsTrue(actualOutput.Count == 0);
        }

        [TestMethod]
        public void PreorderTraverse0ElementsNonRecursively()
        {
            //add elements to the tree
            _PopulateTree(input0Elements);

            //traverse
            List<int> actualOutput = new List<int>();
            bst.PreorderTreversalNonRecursively((value) => {
                Console.Write(value + " ");
                actualOutput.Add(value.Get());
            });

            //check
            Assert.IsTrue(actualOutput.Count == 0);
        }

        [TestMethod]
        public void PreorderTraverse3ElementsRecursively()
        {
            //add elements to the tree
            _PopulateTree(input3Elements);

            //traverse
            List<int> actualOutput = new List<int>();
            bst.PreorderTreversal((value) => {
                Console.Write(value + " ");
                actualOutput.Add(value.Get());
            });

            //check
            Assert.IsTrue(actualOutput.Count > 0);
            for (int i = 0; i < input3Elements.Count; i++)
                Assert.AreEqual(expectedOutput3Elements[i], actualOutput[i]);           
        }

        [TestMethod]
        public void PreorderTraverse3ElementsNonRecursively()
        {
            //add elements to the tree
            _PopulateTree(input3Elements);

            //traverse
            List<int> actualOutput = new List<int>();
            bst.PreorderTreversalNonRecursively((value) => {
                Console.Write(value + " ");
                actualOutput.Add(value.Get());
            });

            //check
            Assert.IsTrue(actualOutput.Count > 0);
            for (int i = 0; i < input3Elements.Count; i++)
                Assert.AreEqual(expectedOutput3Elements[i], actualOutput[i]);
        }

        [TestMethod]
        public void PreorderTraverse10ElementsRecursively()
        {
            //add elements to the tree
            _PopulateTree(input10Elements);

            //traverse
            List<int> actualOutput = new List<int>();
            bst.PreorderTreversal((value) => {
                Console.Write(value + " ");
                actualOutput.Add(value.Get());
            });

            //check
            Assert.IsTrue(actualOutput.Count > 0);
            for (int i = 0; i < input10Elements.Count; i++)
                Assert.AreEqual(expectedOutput10Elements[i], actualOutput[i]);
        }

        [TestMethod]
        public void PreorderTraverse10ElementsNonRecursively()
        {
            //add elements to the tree
            _PopulateTree(input10Elements);

            //traverse
            List<int> actualOutput = new List<int>();
            bst.PreorderTreversalNonRecursively((value) => {
                Console.Write(value + " ");
                actualOutput.Add(value.Get());
            });

            //check
            Assert.IsTrue(actualOutput.Count > 0);
            for (int i = 0; i < input10Elements.Count; i++)
                Assert.AreEqual(expectedOutput10Elements[i], actualOutput[i]);
        }
    }
}
