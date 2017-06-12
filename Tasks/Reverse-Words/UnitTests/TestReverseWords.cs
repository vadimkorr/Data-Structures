using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reverse_Words;

namespace UnitTests
{
    [TestClass]
    public class TestReverseWords
    {
        [TestMethod]
        public void ReverseWordIfIsOk()
        {
            //Arrange
            string input = "piglet quantum";
            string expected = "quantum piglet";

            //Act
            Solution.ReverseWords(ref input);

            //Assert
            Assert.IsTrue(input.Equals(expected));
        }

        [TestMethod]
        public void ReverseWordIfEmptyString()
        {
            //Arrange
            string input = "";
            string expected = "";

            //Act
            Solution.ReverseWords(ref input);

            //Assert
            Assert.IsTrue(input.Equals(expected));
        }

        [TestMethod]
        public void ReverseWordIfSpaces()
        {
            //Arrange
            string input = "     ";
            string expected = "     ";

            //Act
            Solution.ReverseWords(ref input);

            //Assert
            Assert.IsTrue(input.Equals(expected));
        }

        [TestMethod]
        public void ReverseWordIfInputIsASingleLettersWithSpaces()
        {
            //Arrange
            string input = " a b c d     e";
            string expected = "e     d c b a ";

            //Act
            Solution.ReverseWords(ref input);

            //Assert
            Console.WriteLine(input);
            Assert.IsTrue(input.Equals(expected));
        }
    }
}
