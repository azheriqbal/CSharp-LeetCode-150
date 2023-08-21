using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCases
{
    public class SearchAlgosTests
    {
        private int[] sortedArray = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };

        [TestCase(16, 4)]
        [TestCase(2, 0)]
        [TestCase(91, 9)]
        [TestCase(20, -1)]
        public void TestBinarySearch(int target, int expectedIndex)
        {
            int index = SearchAlogs.BinarySearch(sortedArray, target);
            Assert.AreEqual(expectedIndex, index);
        }
    }
}
