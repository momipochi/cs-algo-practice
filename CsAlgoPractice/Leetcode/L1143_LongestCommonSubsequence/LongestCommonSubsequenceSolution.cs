﻿namespace CsAlgoPractice.Leetcode.L1143_LongestCommonSubsequence;

public class LongestCommonSubsequenceSolution
{
    public int LongestCommonSubsequence(string text1, string text2)
    {
        int[][] dp = new int [text1.Length+1][];
        for (int i = 0; i < dp.Length; i++)
        {
            dp[i] = new int[text2.Length+1];
        }

        for (int i = text1.Length-1; i >=0 ; i--)
        {
            for (int j = text2.Length-1; j >=0; j--)
            {
                if (text1[i] == text2[j])
                {
                    dp[i][j] = dp[i + 1][j + 1] + 1;
                }
                else
                {
                    dp[i][j] = Math.Max(dp[i + 1][j], dp[i][j + 1]);
                }
            }
        }
        
        return dp[0][0];
    }
}