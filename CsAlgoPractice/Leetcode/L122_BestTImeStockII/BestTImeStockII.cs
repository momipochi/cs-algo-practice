﻿namespace CsAlgoPractice.Leetcode.L122_BestTImeStockII;

public class BestTImeStockII
{
    public int MaxProfit(int[] prices)
    {
        int res = 0;
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] > prices[i-1])
            {
                res += prices[i] - prices[i - 1];
            }
        }

        return res;
    }
}