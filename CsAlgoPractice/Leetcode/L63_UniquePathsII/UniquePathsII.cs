namespace CsAlgoPractice.Leetcode.L63_UniquePathsII;

public class UniquePathsII
{
    public int UniquePathsWithObstacles(int[][] obstacleGrid)
    {
        int[][] dp = new int[obstacleGrid.Length][];
        for (int i = 0; i < dp.Length; i++)
        {
            dp[i] = new int[obstacleGrid[0].Length];
        }
        dp[0][0] = obstacleGrid[0][0] == 1 ? 0 : 1;
        for (int i = 0; i < dp.Length; i++)
        {
            for (int j = 0; j < dp[i].Length; j++)
            {
                if (obstacleGrid[i][j] == 0)
                {
                    if (i > 0)
                    {
                        dp[i][j] += dp[i - 1][j];
                    }

                    if (j > 0)
                    {
                        dp[i][j] += dp[i][j - 1];
                    }
                }
            }
        }

        return dp[obstacleGrid.Length-1][obstacleGrid[0].Length-1];
    }
}