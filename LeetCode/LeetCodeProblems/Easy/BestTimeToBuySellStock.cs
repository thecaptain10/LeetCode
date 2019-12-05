using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    public class BestTimeToBuySellStock
    {
        //https://leetcode.com/problems/best-time-to-buy-and-sell-stock/
        //Say you have an array for which the ith element is the price of a given stock on day i.
        // If you were only permitted to complete at most one transaction(i.e., buy one and sell one share of the stock), design an algorithm to find the maximum profit.
        //O(n)
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            int min = int.MaxValue;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < min)
                {   // if price is less then previous min, update min
                    min = prices[i];
                }
                else
                {
                    //check profit if sold today
                    maxProfit = Math.Max(maxProfit, prices[i] - min);
                }
            }
            return maxProfit;
        }
    }
}
