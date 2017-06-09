using Binary_Search_Tree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class TestToMinHeap
    {
        BinarySearchTree<int> bst;

        [TestInitialize]
        public void Init()
        {
            bst = Utils.GetNewTree();
        }

        [TestMethod]
        public void TestToMinHeapIfInputIsOk()
        {
            List<int> input10Elements = new List<int>() { 5, 3, 8, 1, 4, 0, 2, 9, 7, 6 };
            List<int> expected = new List<int>() { 0, 1, 3, 7, 8, 4, 9, 2, 5, 6 };
            Utils.PopulateTree(input10Elements, bst);

            Node<int> root = bst.ToMinHeap();

            Assert.IsTrue(root.Value.Get() == 0);

            bst.Root = root;
            int index = 0;
            bst.PreorderTreversal((value) => {
                Console.Write(value.Get() + " ");
                Assert.AreEqual(expected[index], value.Get());
                index++;
            });
        }
    }
}
