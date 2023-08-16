using Dsa;
using NUnit.Framework.Internal;


namespace TestCases
{
    [TestFixture]
    public class MergeArraysTests
    {
        [TestCase(new int[0], new int[0], 0, 0, new int[0])]
       // [TestCase(new int[0], new int[] { 2, 5, 7 }, 0, 3, new int[] { 2, 5, 7 })]
        [TestCase(new int[] { 1, 3, 6 }, new int[0], 3, 0, new int[] { 1, 3, 6 })] // Fixed this line
        [TestCase(new int[] { 1, 3, 6, 0, 0, 0 }, new int[] { 2, 4, 7 }, 3, 3, new int[] { 1, 2, 3, 4, 6, 7 })]
        public void MergeSorted_ShouldMergeArrays(int[] num1, int[] num2, int m, int n, int[] expected)
        {
            MergeArrays.MergeSorted(num1, num2, m, n);
            Assert.AreEqual(expected, num1);
        }
    }
}
