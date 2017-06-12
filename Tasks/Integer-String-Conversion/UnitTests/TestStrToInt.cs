using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Integer_String_Conversion;

namespace UnitTests
{
    [TestClass]
    public class TestStrToInt
    {
        [TestMethod]
        [DataRow("0", 0)]
        [DataRow("1", 1)]
        [DataRow("-1", -1)]
        [DataRow("365", 365)]
        public void StrToIntTest(string input, int expected)
        {
            //Act
            int actual = Solution.StrToInt(input);

            //Assert
            Console.WriteLine(actual);
            Assert.AreEqual(expected, actual);
        }
    }
}
