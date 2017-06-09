using Microsoft.VisualStudio.TestTools.UnitTesting;
using Binary_Search_Tree;
using Binary_Search_Tree.ExtraModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTests
{
    [TestClass]
    public class TestInorderTraversal
    {
        BinarySearchTree<int> bst;

        [TestInitialize]
        public void Init()
        {
            bst = Utils.GetNewTree();
        }

        [TestMethod]
        public void Traverse3Elements()
        {
            List<int> input = new List<int>() { 20, 30, 10 };
            List<int> expectedOutput = new List<int>() { 10, 20, 30 };
            
            //add elements to the tree
            foreach (int value in input)
                bst.InsertNode(new ComparableValue(value));

            //traverse
            List<int> actualOutput = new List<int>();
            bst.InorderTraversal((value) => {
                Console.Write(value + " ");
                actualOutput.Add(value.Get());
            });

            //check
            Assert.IsTrue(actualOutput.Count > 0);
            for (int i = 0; i < input.Count; i++)
                Assert.AreEqual(expectedOutput[i], actualOutput[i]);           
        }

        [TestMethod]
        public void Traverse10Elements()
        {
            List<int> input = new List<int>();
            
            //expected ordered sequence
            List<int> expectedOutput = new List<int>();
            for (int i = 0; i < 10; i++)
                expectedOutput.Add(i);

            //shuffle input randomly
            Random rnd = new Random();
            input = expectedOutput.OrderBy(c => rnd.Next()).Select(c => c).ToList();

            //add elements to the tree
            foreach (int value in input)
                bst.InsertNode(new ComparableValue(value));

            //traverse
            List<int> actualOutput = new List<int>();
            bst.InorderTraversal((value) => {
                Console.Write(value + " ");
                actualOutput.Add(value.Get());
            });

            //check
            Assert.IsTrue(actualOutput.Count > 0);
            for (int i = 0; i < input.Count; i++)
                Assert.AreEqual(expectedOutput[i], actualOutput[i]);
        }
    }
}
