namespace CsAlgoPractice.Leetcode.L64_MinPathSum;

public class MinPathSumSolution
{
    public int MinPathSum(int[][] grid)
    {
        int[][] dp = new int[grid.Length][];
        dp[0] = new int[grid[0].Length];
        dp[0][0] = grid[0][0];
        for (int i = 1; i < grid.Length; i++)
        {
            dp[i] = new int[grid[i].Length];
            dp[i][0] = dp[i-1][0] + grid[i][0];

        }

        for (int i = 1; i < grid[0].Length; i++)
        {
            dp[0][i] = dp[0][i - 1] + grid[0][i];
        }
        for (int i = 1; i < grid.Length; i++)
        {
            for (int j = 1; j < grid[i].Length; j++)
            {
                dp[i][j] = Math.Min(dp[i - 1][j] + grid[i][j], dp[i][j - 1] + grid[i][j]);
            }
        }
        return dp[^1][^1];
    }
}