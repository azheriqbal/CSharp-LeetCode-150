using Dsa;

namespace TestCases
{
    [TestFixture]
    public class ArraysLeetCodeTests
    {
        [Test]
        public void TestMajorityElement()
        {
            int[] nums1 = { 3, 2, 3 };
            int expected1 = 3;

            int result1 = ArraysLeetCode.MajorityElement(nums1);

            Assert.AreEqual(expected1, result1);

            int[] nums2 = { 2, 2, 1, 1, 1, 2, 2 };
            int expected2 = 2;

            int result2 = ArraysLeetCode.MajorityElement(nums2);

            Assert.AreEqual(expected2, result2);
        }
        [Test]
        public void TestMergeSorted()
        {
            int[] num1 = { 1, 2, 3, 0, 0, 0 };
            int[] num2 = { 2, 5, 6 };
            int m = 3;
            int n = 3;
            int[] expected = { 1, 2, 2, 3, 5, 6 };

            ArraysLeetCode.MergeSorted(num1, num2, m, n);

            Assert.AreEqual(expected, num1);
        }

        [Test]
        public void TestRemoveDuplicates()
        {
            int[] nums = { 1, 1, 2 };
            int expectedLength = 2;

            int resultLength = ArraysLeetCode.RemoveDuplicates(nums);

            Assert.AreEqual(expectedLength, resultLength);
            Assert.AreEqual(nums.Take(expectedLength), nums.Take(resultLength));
        }

        [Test]
        public void TestRemoveDuplicates2()
        {
            int[] nums = { 0, 0, 1, 1, 1, 1, 2, 3, 3 };
            int expectedLength = 7;

            int resultLength = ArraysLeetCode.RemoveDuplicates2(nums);

            Assert.AreEqual(expectedLength, resultLength);
            Assert.AreEqual(nums.Take(expectedLength), nums.Take(resultLength));
        }

        [Test]
        public void TestRemoveEl()
        {
            int[] num = { 3, 2, 2, 3 };
            int val = 3;
            int expectedLength = 2;

            int resultLength = ArraysLeetCode.RemoveEl(num, val);

            Assert.AreEqual(expectedLength, resultLength);
            Assert.AreEqual(num.Take(expectedLength), num.Take(resultLength));
        }

        [TestCase("A man, a plan, a canal, Panama", true)]
        [TestCase("race a car", false)]
        [TestCase("", true)]
        [TestCase("a", true)]
        [TestCase("Able was I, I saw elba", true)]
        [TestCase("No 'x' in Nixon", true)]
        [TestCase("!@#$%^&*()", true)]
        public void TestIsPhilandrom(string input, bool expected)
        {
            bool result = ArraysLeetCode.IsPhilandrom(input);
            Assert.AreEqual(expected, result);
        }
    }

}
