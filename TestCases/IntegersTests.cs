using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCases
{

    [TestFixture]
    public class IntegersTests
    {
        [TestCase("III", 3)]
        [TestCase("IV", 4)]
        [TestCase("IX", 9)]
        [TestCase("LVIII", 58)]
        [TestCase("MCMXCIV", 1994)]
        public void TestRomanToInt(string input, int expected)
        {
            int result = Integers.RomanToInt(input);
            Assert.AreEqual(expected, result);
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2, 4 })]
        [TestCase(new int[] { 9, 9, 9 }, new int[] { 1, 0, 0, 0 })]
        [TestCase(new int[] { 0 }, new int[] { 1 })]
        public void TestPlusOne(int[] input, int[] expected)
        {
            int[] result = Integers.PlusOne(input);
            Assert.AreEqual(expected, result);
        }
    }

}
