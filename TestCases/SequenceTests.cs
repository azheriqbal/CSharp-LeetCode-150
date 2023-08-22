using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TestCases
{
    public class SequenceTests
    {
        [Test]
        public void TestClimbStairs()
        {
            Assert.AreEqual(1, Sequence.ClimbStairs(1));
            Assert.AreEqual(2, Sequence.ClimbStairs(2));
            Assert.AreEqual(3, Sequence.ClimbStairs(3));
            Assert.AreEqual(5, Sequence.ClimbStairs(4));
            Assert.AreEqual(8, Sequence.ClimbStairs(5));
            Assert.AreEqual(13, Sequence.ClimbStairs(6));
        }

        [TestCase(new[] { "flower", "flow", "flight" }, "fl")]
        [TestCase(new[] { "dog", "racecar", "car" }, "No Sequence is Found")]
        [TestCase(new[] { "apple", "banana", "cherry" }, "No Sequence is Found")]
        [TestCase(new[] { "abc", "abcd", "abcde" }, "abc")]
        public void TestLongestCommonPrefix(string[] strs, string expected)
        {
            // Act
            string result = Sequence.LongestCommonPrefix(strs);

            // Assert
            Assert.AreEqual(expected, result);
        }


        [TestCase("ace", "abcde", ExpectedResult = true)]
        [TestCase("aec", "abcde", ExpectedResult = false)]
        [TestCase("abc", "abcde", ExpectedResult = true)]
        [TestCase("bd", "abcd", ExpectedResult = true)]
        [TestCase("", "abcde", ExpectedResult = true)]
        [TestCase("xyz", "abcde", ExpectedResult = false)]
        public bool TestIsSubsequence(string s, string t)
        {
            return Sequence.IsSubsequence(s, t);
        }

        [TestCase("Hello World", ExpectedResult = 5)]
        [TestCase("   The quick brown fox   ", ExpectedResult = 3)]
        [TestCase("", ExpectedResult = 0)]
        [TestCase("OneWord", ExpectedResult = 7)]
        [TestCase("   ", ExpectedResult = 0)]
        [TestCase("Hello  ", ExpectedResult = 5)]
        public int TestLengthOfLastWord(string input)
        {
            return Sequence.LengthOfLastWord(input);
        }
    }
}
