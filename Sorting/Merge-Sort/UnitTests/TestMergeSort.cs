using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Merge_Sort;

namespace UnitTests
{
    [TestClass]
    public class TestMergeSort
    {
        [TestMethod]
        [DataRow(new int[] { }, new int[] { })]
        [DataRow(new int[] { 5 }, new int[] { 5 })]
        [DataRow(new int[] { 5, 4, 9, 1, 7, 0 }, new int[] { 0, 1, 4, 5, 7, 9 })]
        public void TestSort(int[] input, int[] expected)
        {
            MergeSort sorter = new MergeSort();

            //Act
            sorter.DoMergeSort(input);

            //Assert
            for (int i = 0; i < input.Length; i++)
            {
                Assert.AreEqual(expected[i], input[i]);
            }
        }
    }
}
