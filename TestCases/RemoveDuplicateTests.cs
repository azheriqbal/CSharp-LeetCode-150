using Dsa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCases
{
    public class RemoveDuplicateTests
    {
        [TestCase(new int[] { 1, 1, 2 }, ExpectedResult = 2)]
        [TestCase(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, ExpectedResult = 5)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = 5)]
        [TestCase(new int[] { 1, 1, 1, 1, 1 }, ExpectedResult = 1)]
        [TestCase(new int[] { }, ExpectedResult = 0)]
        public int RemoveDuplicates_ShouldReturnLengthOfUniqueElements(int[] nums)
        {
            return RemoveDuplicate.RemoveDuplicates(nums);
        }
    }
}
