using Dsa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCases
{
    [TestFixture]
    public class StringLeetCodeTests
    {
        [TestCase("   hello world!  ", "world! hello")]
        [TestCase("  the  sky is   blue  ", "blue is sky the")]
        [TestCase("   a good   example   ", "example good a")]
        [TestCase("apple", "apple")]
        [TestCase("", "")]
        public void ReverseWords_ValidInput_ReturnsReversedString(string input, string expected)
        {
            // Act
            string result = StringLeetCode.ReverseWords(input);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
