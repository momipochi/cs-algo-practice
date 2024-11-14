namespace Leetcode;

public class NQueensII
{

    public int TotalNQueens(int n)
    {
        bool[] cols = new bool[n];
        bool[] diag1 = new bool[2 * n - 1];
        bool[] diag2 = new bool[2 * n - 1];

        int helper(int i)
        {
            if (i == n)
            {
                return 1;
            }
            int count = 0;
            for (int j = 0; j < n; j++)
            {
                if (cols[j] || diag1[i + j] || diag2[j - i + n - 1])
                    continue;
                cols[j] = diag1[i + j] = diag2[j - i + n - 1] = true;
                count += helper(i + 1);
                cols[j] = diag1[i + j] = diag2[j - i + n - 1] = false;
            }
            return count;
        }
        return helper(0);
    }
}