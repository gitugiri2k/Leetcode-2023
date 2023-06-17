using System;
namespace Leetcode_2023
{
    public class LT_121_BestTimeto_Buy_and_Sell_Stock
    {
        public LT_121_BestTimeto_Buy_and_Sell_Stock()
        {
        }
        /*
		 * Input: prices = [7,1,5,3,6,4]
Output: 5
Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
		 n = length of array
while loop till n
		start = price[i]
		while(j=i<n-1)
		if(price[j]>start){


         */

        public int MaxProfit(int[] prices)
        {
            int n = prices.Length;
            int start = int.MaxValue;
            int profit = 0;
            for (int i = 0; i <= n - 1; i++)
            {
                start = Math.Min(start,prices[i]);
                profit = Math.Max(prices[i] - start, profit);
            }
            return profit;
        }
    }
}

