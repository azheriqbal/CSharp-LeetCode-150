using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsa
{
    public class RemoveDuplicate
    {
        public static int RemoveDuplicates(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i<nums.Length-1 && nums[i] == nums[i + 1])
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
    }
}
