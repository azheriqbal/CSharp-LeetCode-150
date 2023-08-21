using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Water
    {
        public static int Trap(int[] height)
        {
            int n = height.Length;
            if (n == 0) return 0;

            // Step 1: Initialize arrays to store maximum heights from the left and right
            int[] maxLeft = new int[n];
            int[] maxRight = new int[n];
            maxLeft[0] = height[0];
            maxRight[n - 1] = height[n - 1];

            // Step 2: Fill the maxLeft array with maximum heights from the left side
            for (int i = 1; i < n; i++)
            {
                maxLeft[i] = Math.Max(maxLeft[i - 1], height[i]);
            }

            // Step 3: Fill the maxRight array with maximum heights from the right side
            for (int i = n - 2; i >= 0; i--)
            {
                maxRight[i] = Math.Max(maxRight[i + 1], height[i]);
            }

            int trappedWater = 0;

            // Step 4: Calculate trapped water at each position
            for (int i = 0; i < n; i++)
            {
                trappedWater += Math.Max(0, Math.Min(maxLeft[i], maxRight[i]) - height[i]);
            }

            return trappedWater;
        }
    }
}
