using Dsa;

namespace TestCases
{


    [TestFixture]
    public class RemoveElementTests
    {
        [TestCase(new[] { 3, 2, 2, 3 }, 3, 2, new[] { 2, 2 })]
        [TestCase(new[] { 1, 2, 3, 4 }, 5, 4, new[] { 1, 2, 3, 4 })]
        [TestCase(new[] { 3, 3, 3, 3 }, 3, 0, new int[0])]
        [TestCase(new int[0], 7, 0, new int[0])]
        public void TestRemoveElement(int[] nums, int val, int expectedLength, int[] expectedArray)
        {
            int result = RemoveElement.RemoveEl(nums, val);

            Assert.AreEqual(expectedLength, result);
            for (int i = 0; i < expectedLength; i++)
            {
                Assert.AreEqual(expectedArray[i], nums[i]);
            }
        }
    }

}
