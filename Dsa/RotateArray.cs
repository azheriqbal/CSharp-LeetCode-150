using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RotateArray
    {

        public static void Reverse(int[] nums, int start, int end)
        {
            while(start < end)
            {
                int tem = nums[start];
                nums[start] = nums[end];
                nums[end] = tem;
                start++;
                end--;
            }
        }

        public static void Rotate(int[] nums, int k)
        {
            int n = nums.Length;
            k = k % n;
            // k = 7 and n = 5, then k % n is 7 % 5 = 2. You only need to rotate by 2 positions.
            // k = 13 and n = 5, then k % n is 13 % 5 = 3.You only need to rotate by 3
            Reverse(nums, 0, n-1);
            Reverse(nums,0,k-1);
            Reverse(nums,k, n-1);
        }
    }
}

