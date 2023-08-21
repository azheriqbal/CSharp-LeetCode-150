using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCases
{
    [TestFixture]
    public class RotateArrayTests
    {
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3, ExpectedResult = new int[] { 5, 6, 7, 1, 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 2, ExpectedResult = new int[] { 5, 6, 1, 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 7, ExpectedResult = new int[] { 4, 5, 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0, ExpectedResult = new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1 }, 2, ExpectedResult = new int[] { 1 })]
        public int[] TestRotate(int[] nums, int k)
        {
            RotateArray.Rotate(nums, k);
            return nums;
        }
    }
}
