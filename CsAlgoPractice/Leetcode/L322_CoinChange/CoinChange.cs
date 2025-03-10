﻿namespace CsAlgoPractice.Leetcode.L322_CoinChange;

public class CoinChange
{
    public int coinChange(int[] coins, int amount)
    {
        var dp = new int[amount + 1];
        Array.Fill(dp,amount+1);
        dp[0] = 0;

        for (int i = 0; i <= amount; i++)
        {
            foreach (var coin in coins)
            {
                if (i >= coin)
                {
                    dp[i] = Math.Min(dp[i],dp[i-coin]+1);
                }
            }
        }
        
        return dp[amount] > amount ? -1 : dp[amount];
    }
}