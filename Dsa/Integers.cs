using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Integers
    {
        public static int RomanToInt(string s)
        {
            // Dictionary to store Roman numeral characters and their corresponding values
            Dictionary<char, int> romanValues = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

            int total = 0;       // Initialize the total value
            int prevValue = 0;   // Initialize the value of the previous Roman numeral character

            // Iterate through the Roman numeral string from right to left
            for (int i = s.Length - 1; i >= 0; i--) // XI
            {
                int currentValue = romanValues[s[i]]; // Get the value of the current character

                // Compare the current value with the previous value to decide whether to add or subtract
                if (currentValue >= prevValue)
                    total += currentValue; // Add the current value to the total
                else
                    total -= currentValue; // Subtract the current value from the total

                prevValue = currentValue; // Update the previous value for the next iteration
            }

            return total; // Return the final calculated total
        }


    }


}
