using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Remove_Chars;

namespace UnitTests
{
    [TestClass]
    public class TestRemoveChars
    {
        [TestMethod]
        public void RemoveCharIfOk()
        {
            //Arrange
            string str = "Battle of the Vowels: Hawaii vs. Grozny";
            string rem = "aeiou";
            string expected = "Bttl f th Vwls: Hw vs. Grzny";

            //Act
            string actual = Solution.RemoveChars(str, rem);

            //Assert
            Assert.IsTrue(expected.Equals(actual));
        }

        [TestMethod]
        public void RemoveCharIfStrIsEmpty()
        {
            //Arrange
            string str = "";
            string rem = "aeiou";
            string expected = "";

            //Act
            string actual = Solution.RemoveChars(str, rem);

            //Assert
            Assert.IsTrue(expected.Equals(actual));
        }

        [TestMethod]
        public void RemoveCharIfRemIsEmpty()
        {
            //Arrange
            string str = "Hello!";
            string rem = "";
            string expected = "Hello!";

            //Act
            string actual = Solution.RemoveChars(str, rem);

            //Assert
            Assert.IsTrue(expected.Equals(actual));
        }

        [TestMethod]
        public void RemoveCharIfBothAreEmpty()
        {
            //Arrange
            string str = "";
            string rem = "";
            string expected = "";

            //Act
            string actual = Solution.RemoveChars(str, rem);

            //Assert
            Assert.IsTrue(expected.Equals(actual));
        }

        [TestMethod]
        public void RemoveCharIfThereAreSameCharsInRem()
        {
            //Arrange
            string str = "Hello eee!";
            string rem = "ee";
            string expected = "Hllo !";

            //Act
            string actual = Solution.RemoveChars(str, rem);

            //Assert
            Assert.IsTrue(expected.Equals(actual));
        }
    }
}
