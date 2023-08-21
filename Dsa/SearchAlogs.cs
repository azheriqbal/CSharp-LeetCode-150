using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class SearchAlogs
    {
        public static int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                    return mid; // Target found at index mid

                if (array[mid] < target)
                    left = mid + 1; // Search in the right half
                else
                    right = mid - 1; // Search in the left half
            }

            return -1; // Target not found
        }

    }
}
