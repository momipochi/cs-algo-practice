namespace CsAlgoPractice.Leetcode.L931_MinimumFallingPathSum;

public class MinimumFallingPathSum
{
    public int MinFallingPathSum(int[][] matrix)
    {
        var dp = new int[matrix.Length][];
        dp[0] = new int[matrix[0].Length];
        for (int i = 0; i < matrix[0].Length; i++)
        {
            dp[0][i] = matrix[0][i];
        }

        for (int i = 1; i < matrix.Length; i++)
        {
            dp[i] = new int[matrix[0].Length];

            for (int j = 0; j < matrix[0].Length; j++)
            {
                var m = matrix[i][j];
                var min =  m + dp[i-1][j];
                if (j - 1 >= 0)
                {
                    min = Math.Min(min, m + dp[i - 1][j - 1]);
                }

                if (j + 1 < matrix[0].Length)
                {
                    min = Math.Min(min, m + dp[i - 1][j + 1]);
                }

                dp[i][j] = min;
            }
        }

        var res = dp[^1][0];
        for (int i = 0; i < dp[0].Length; i++)
        {
            if (dp[^1][i] < res)
            {
                res = dp[^1][i];
            }
        }
        return res;
    }
}