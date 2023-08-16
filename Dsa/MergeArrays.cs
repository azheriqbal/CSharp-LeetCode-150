using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsa
{
    public class MergeArrays
    {
        public static void MergeSorted(int[] num1, int[] num2, int m, int n)
        {
            int i = m - 1;
            int j = n - 1;
            int k = m + n - 1;

            while(j >= 0)
            {
                if(i >=0 && num1[i]> num2[j])
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
    }
}
