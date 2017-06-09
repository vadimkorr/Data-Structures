using Microsoft.VisualStudio.TestTools.UnitTesting;
using Binary_Search_Tree;
using Binary_Search_Tree.ExtraModels;

namespace UnitTests
{
    [TestClass]
    public class TestAdd
    {
        BinarySearchTree<int> bst;

        [TestInitialize]
        public void Init()
        {
            bst = Utils.GetNewTree();
        }

        [TestMethod]
        public void AddInEmptyTree()
        {
            int valueToAdd = 5;
            bst.InsertNode(new ComparableValue(valueToAdd));
            Assert.AreEqual(bst.Root.Value.Get(), valueToAdd);
        }

        [TestMethod]
        public void AddLessThan()
        {
            int valueToAdd = 5;
            bst.InsertNode(new ComparableValue(valueToAdd));
            Assert.AreEqual(bst.Root.Value.Get(), valueToAdd);

            int lessThanValueToAdd = 3;
            bst.InsertNode(new ComparableValue(lessThanValueToAdd));
            Assert.AreEqual(bst.Root.Value.Get(), valueToAdd);
        }

        [TestMethod]
        public void AddGraterThan()
        {
            int valueToAdd = 5;
            bst.InsertNode(new ComparableValue(valueToAdd));
            Assert.AreEqual(bst.Root.Value.Get(), valueToAdd);

            int graterThanValueToAdd = 10;
            bst.InsertNode(new ComparableValue(graterThanValueToAdd));
            Assert.AreEqual(bst.Root.Value.Get(), valueToAdd);
        }


        /*[TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethod2()
        {
            // assert is handled by ExpectedException
        }*/
    }
}
