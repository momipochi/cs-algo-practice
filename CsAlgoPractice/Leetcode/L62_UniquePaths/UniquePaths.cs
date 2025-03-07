﻿namespace CsAlgoPractice.Leetcode.L62_UniquePaths;

public class UniquePaths
{
    public int UniquePathsSolution(int m, int n)
    {
        int[][] dp = new int[m][];
        for (int i = 0; i < m; i++)
        {
            dp[i] = new int[n];
            Array.Fill(dp[i],1);

        }
        for (int i = 1; i < m; i++)
        {
            for (int j = 1; j < n; j++)
            {
                dp[i][j] = dp[i - 1][j] + dp[i][j - 1];
            }
        }
        return dp[m-1][n-1];
    }
}