using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCases
{
    public class SumsTests
    {
        [TestCase(new int[] { 2, 7, 11, 15 }, 9, new int[] { 1, 2 })]
        [TestCase(new int[] { 2, 3, 4 }, 6, new int[] { 1, 3 })]
        [TestCase(new int[] { -1, 0 }, -1, new int[] { 1, 2 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 9 }, 13, new int[] { 4, 8 })]
        public void TestTwoSum_ValidInput(int[] numbers, int target, int[] expected)
        {
            // Arrange
            

            // Act
            int[] result = Sums.TwoSumSorted(numbers, target);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        [TestCase(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [TestCase(new int[] { -1, 0 }, -1, new int[] { 0, 1 })]
        public void TestTwoSumUnSorted_ValidInput(int[] nums, int target, int[] expected)
        {
            // Arrange

            // Act
            int[] result = Sums.TwoSumUnSorted(nums, target);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
