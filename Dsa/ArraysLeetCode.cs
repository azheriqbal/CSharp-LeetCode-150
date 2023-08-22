using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsa
{
    public class ArraysLeetCode
    {
        public static int MajorityElement(int[] nums)
        {
            int candidate = 0;
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (count == 0)
                {
                    candidate = nums[i];
                }
                if (candidate == nums[i])
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }

            return candidate;
        }

        public static void MergeSorted(int[] num1, int[] num2, int m, int n)
        {
            int i = m - 1;
            int j = n - 1;
            int k = m + n - 1;

            while (j >= 0)
            {
                if (i >= 0 && num1[i] > num2[j])
                {
                    num1[k] = num1[i];
                    i--;
                    k--;
                }
                else
                {
                    num1[k] = num2[j];
                    j--;
                    k--;
                }
            }
        }

        public static int RemoveDuplicates(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i < nums.Length - 1 && nums[i] == nums[i + 1])
                {
                    continue;
                }
                else
                {
                    nums[count] = nums[i];
                    count++;
                }

            }
            return count;
        }

        public static int RemoveDuplicates2(int[] nums)
        {
            if (nums.Length <= 2)
            {
                return nums.Length;
            }

            int k = 2;
            for (int i = 2; i < nums.Length; i++)
            {
                if (nums[i] != nums[k - 2])
                {
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k;
        }

        public static int RemoveEl(int[] num, int val)
        {
            int count = 0;
            for (var i = 0; i < num.Length; i++)
            {
                if (num[i] != val)
                {
                    num[count] = num[i];
                    count++;
                }

            }

            return count;
        }

        public static bool IsPhilandrom(string s)
        {
            s = s.ToLower();
            s = new string(s.Where(char.IsLetterOrDigit).ToArray());
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;

        }

        public static int MinSizeSubarraySum(int[] arr, int target)
        {
            int n = arr.Length;
            int minLength = int.MaxValue; // Initialize minLength to a large value
            int windowSum = 0; // Initialize the sum of the current window
            int left = 0; // Initialize the left pointer

            for (int right = 0; right < n; right++)
            {
                windowSum += arr[right]; // Expand the window by adding the current element

                while (windowSum >= target)
                {
                    minLength = Math.Min(minLength, right - left + 1); // Update minLength if a smaller subarray is found
                    windowSum -= arr[left]; // Shrink the window by removing the left element
                    left++; // Move the left pointer to the right
                }
            }

            return minLength == int.MaxValue ? 0 : minLength; // Return the found minLength or 0 if no valid subarray found


        }
    }
}
