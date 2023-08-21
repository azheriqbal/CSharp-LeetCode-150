using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Product
    {
        public static int[] ProductExceptSelf(int[] nums)
        {
            int[] res = new int[nums.Length];
            int[] prefixStart= new int[nums.Length];
            int[] prefixEnd = new int[nums.Length];

            prefixStart[0] = nums[0];
            for(int i =0; i< nums.Length; i++)
            {
                prefixStart[i] = prefixStart[i-1] * nums[i];
            }


            return res;
        }

        public static int[] ProductExceptSelf_1(int[] nums)
        {
            int n = nums.Length;
            int[] result = new int[n];
            int arrayProduct = 1;
            foreach (int i in nums)
            {
                arrayProduct *= i;
            }

            for(int i = 0; i < n; i++)
            {
                result[i] = arrayProduct / nums[i];
            }

            return result;

           

        }

    }
}
