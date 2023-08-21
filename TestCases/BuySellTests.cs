using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCases
{
    [TestFixture]
    public class BuySellTests
    {
        [TestCase(new int[] { 7, 1, 5, 3, 6, 4 }, 7)]
        [TestCase(new int[] { 7, 6, 4, 3, 1 }, 0)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4)]
        [TestCase(new int[] { }, 0)]
        public void Test_MaxProfitII(int[] prices, int expected)
        {
            // Act
            int maxProfit = BuySell.MaxProfitII(prices);

            // Assert
            Assert.AreEqual(expected, maxProfit);
        }


        [TestCase(new int[] { 7, 1, 5, 3, 6, 4 }, ExpectedResult = 5)]
        [TestCase(new int[] { 7, 6, 4, 3, 1 }, ExpectedResult = 0)]
        [TestCase(new int[] { 10, 9, 8, 7, 6, 5 }, ExpectedResult = 0)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, ExpectedResult = 5)]
        [TestCase(new int[] { 3, 8, 1, 6, 4, 7, 2 }, ExpectedResult = 6)]
        public int Test1_MaxProfit(int[] days)
        {
            return BuySell.MaxProfitBruteForce(days);
        }


        [TestCase(new int[] { 7, 1, 5, 3, 6, 4 }, ExpectedResult = 5)]
        [TestCase(new int[] { 7, 6, 4, 3, 1 }, ExpectedResult = 0)]
        [TestCase(new int[] { 10, 9, 8, 7, 6, 5 }, ExpectedResult = 0)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, ExpectedResult = 5)]
        [TestCase(new int[] { 3, 8, 1, 6, 4, 7, 2 }, ExpectedResult = 6)]
        public int Test2_MaxProfit(int[] prices)
        {
            return BuySell.MaxProfit(prices);
        }
    }

}
