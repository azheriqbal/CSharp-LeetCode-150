using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class BuySell
    {
        public static int MaxProfitBruteForce(int[] days)
        {
            int maxProfit = 0;
            for(int i=0; i < days.Length; i++)
            {
                for(int j = i + i; j < days.Length; j++)
                {
                    int profit = days[j] - days[i];
                    maxProfit=Math.Max(maxProfit, profit);
                }
            }
            return maxProfit;
        }

        public static int MaxProfit(int[] prices)
        {
            int minSoFar = prices[0];
            int maxProfit = 0;
            for(int i = 0; i < prices.Length; i++)
            {
                minSoFar = Math.Min(minSoFar, prices[i]);
                int profit= prices[i]-minSoFar;
                maxProfit = Math.Max(maxProfit, profit);
            }
            return maxProfit;
        }

        public static int MaxProfitII(int[] prices)
        {
            int maxProfit = 0;
            for(int i=1; i < prices.Length; i++)
            {
                // If the current day's price is greater than the previous day's price,
                // we can make a profit by buying on the previous day and selling on the current day.
                if (prices[i]> prices[i - 1])
                {
                    maxProfit += prices[i] - prices[i - 1];
                }
            }
            return maxProfit;
        }
    }
}
