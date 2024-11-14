using System.Text;

namespace Leetcode;

public class NQueens
{
    public IList<IList<string>> SolveNQueens(int n)
    {
        IList<IList<string>> res = [];
        bool[] cols = new bool[n];
        bool[] diag1 = new bool[2 * n - 1];
        bool[] diag2 = new bool[2 * n - 1];
        char[][] board = Enumerable.Range(0, n).Select(_ => Enumerable.Repeat('.', n).ToArray()).ToArray();

        void helper(int i)
        {
            if (i == n)
            {
                var tmp = new List<string>();
                for (int j = 0; j < n; j++)
                {
                    tmp.Add(string.Join("", board[j]));
                }
                res.Add(tmp);
                return;
            }
            for (int j = 0; j < n; j++)
            {
                if (cols[j] || diag1[i + j] || diag2[j - i + n - 1])
                    continue;
                board[i][j] = 'Q';
                cols[j] = diag1[i + j] = diag2[j - i + n - 1] = true;
                helper(i + 1);
                cols[j] = diag1[i + j] = diag2[j - i + n - 1] = false;
                board[i][j] = '.';
            }
        }
        helper(0);
        return res;
    }

}