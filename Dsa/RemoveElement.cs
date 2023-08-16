using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dsa
{
    public class RemoveElement
    {
        public static int RemoveEl(int[] num, int val)
        {
            int count = 0;
            for(var i=0; i<num.Length;i++)
            {
                if(num[i] != val)
                {
                    num[count] = num[i];
                    count++;
                }
               
            }

            return count;
        }
    }
}
