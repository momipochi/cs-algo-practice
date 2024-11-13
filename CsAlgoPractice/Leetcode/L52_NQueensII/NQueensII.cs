namespace Leetcode;

public class NQueensII
{

    bool[] cols = [];
    bool[] diag1 = [];
    bool[] diag2 = [];
    int n = 0;
    public int TotalNQueens(int n)
    {
        this.n = n;
        cols = new bool[n];
        diag1 = new bool[2 * n + 1];
        diag2 = new bool[2 * n + 1];
        
        return countQueens(0);
    }

    private int countQueens(int i)
    {
        if (i == n)
        {
            return 1;
        }
        int count = 0;
        for (int j = 0; j < n; j++)
        {
            if (cols[j] || diag1[i + j] || diag2[j - i + n - 1])
            {
                continue;
            }
            cols[j] = diag1[i + j] = diag2[j - i + n - 1] = true;
            count += countQueens(i + 1);
            cols[j] = diag1[i + j] = diag2[j - i + n - 1] = false;
        }
        return count;
    }

}