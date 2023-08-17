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
        [TestCase("anagram", "nagaram", ExpectedResult = true)]
        [TestCase("hello", "world", ExpectedResult = false)]
        [TestCase("", "", ExpectedResult = true)]
        [TestCase("listen", "silent", ExpectedResult = true)]
        [TestCase("abc", "def", ExpectedResult = false)]
        public bool TestIsAnagram(string s, string t)
        {
            return StringLeetCode.IsAnagram(s, t);
        }


        [TestCase("()", ExpectedResult = true)]
        [TestCase("()[]{}", ExpectedResult = true)]
        [TestCase("{[()]}", ExpectedResult = true)]
        [TestCase("(]", ExpectedResult = false)]
        [TestCase("([)]", ExpectedResult = false)]
        [TestCase("]", ExpectedResult = false)]
        [TestCase("", ExpectedResult = true)]
        public bool TestIsValidParentheses(string s)
        {
            return StringLeetCode.IsValidParanthesis(s);
        }


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
