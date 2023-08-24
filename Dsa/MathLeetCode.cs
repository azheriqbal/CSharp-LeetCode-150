using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MathLeetCode
    {
        public static int TrailingZeroes(int n)
        {
            int count = 0; // Initialize a variable to keep track of the count of trailing zeroes.
            int divisor = 5; // Initialize the divisor to 5, which represents the single factor of 5.

            // As long as there are factors of 5 in the factorial of n,
            // continue counting and incrementing the divisor.
            while (n / divisor > 0)
            {
                count += n / divisor; // Add the count of factors of 5 to the total count.
                divisor *= 5; // Increase the divisor to account for the next power of 5.
            }

            return count; // Return the total count of trailing zeroes in the factorial of n.
        }

    }
}
