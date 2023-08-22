using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCases
{
    [TestFixture]
    public class WaterTests
    {
        [TestCase(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }, 49)]
        [TestCase(new int[] { 4, 3, 2, 1, 4 }, 16)]
        [TestCase(new int[] { 1, 2, 1 }, 2)]
        [TestCase(new int[] { 1, 1 }, 1)]
        public void TestMaxArea(int[] height, int expected)
        {
            int result = Water.MaxArea(height);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 4, 2, 0, 3, 2, 5 }, 9)]
        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { 7 }, 0)]
        // Add more test cases as needed
        public void TestTrappedWater(int[] heights, int expected)
        {
            int actual = Water.Trap(heights);
            Assert.AreEqual(expected, actual);
        }
    }
}
