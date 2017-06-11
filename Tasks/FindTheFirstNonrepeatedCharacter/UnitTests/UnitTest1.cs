using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindTheFirstNonrepeatedCharacter;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            /*int[] chars32bitCodes = { 119083, 119083, 119070, 127932, 127932 };
            string input32bit = string.Empty;
            for (int i = 0; i < chars32bitCodes.Length; i++)
            {
                input32bit += char.ConvertFromUtf32(119070);
            }*/

            string input32bit = "\u007A\uD834\uDD1E\u007A";

            //act
            string actual = Solution.FindFirstNonRepeated32(input32bit);

            //assert
            Assert.IsTrue(string.Equals(actual, "\uD834"));
            Console.WriteLine(input32bit);
        }
    }
}
