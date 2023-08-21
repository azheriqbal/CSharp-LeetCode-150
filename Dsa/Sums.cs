using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Sums
    {
        public static int[] TwoSumSorted(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;

            while (left < right)
            {
                int sum = numbers[left] + numbers[right];

                if (sum == target)
                {
                    return new int[] { left + 1, right + 1 }; // Adding 1 to convert to 1-indexed
                }
                else if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            throw new ArgumentException("No solution found.");
        }

        public static int[] TwoSumUnSorted(int[] nums, int target)
        {
            Dictionary<int, int> numToIndexMap = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (numToIndexMap.ContainsKey(complement))
                {
                    return new int[] { numToIndexMap[complement], i };
                }

                numToIndexMap[nums[i]] = i;
            }

            throw new ArgumentException("No solution found.");
        }

    }
}