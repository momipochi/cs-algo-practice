using System.Text;

namespace Leetcode;

public class NQueens
{
    IList<IList<string>> res = [];
    bool[] cols = [];
    bool[] diag1 = [];
    bool[] diag2 = [];
    int n = 0;
    char[][] board = [];
    public IList<IList<string>> SolveNQueens(int n)
    {
        board = Enumerable.Range(0, n).Select(_ => Enumerable.Repeat('.', n).ToArray()).ToArray();
        this.n = n;
        cols = new bool[n];
        diag1 = new bool[2 * n - 1];
        diag2 = new bool[2 * n - 1];
        solveForQueens(0);
        return res;
    }

    private void solveForQueens(int i)
    {
        if (i == n)
        {
            constructString();
            return;
        }

        for (int j = 0; j < cols.Length; j++)
        {
            if (cols[j] || diag1[i + j] || diag2[j - i + n - 1])
            {
                continue;
            }
            board[i][j] = 'Q';
            cols[j] = diag1[i + j] = diag2[j - i + n - 1] = true;
            solveForQueens(i + 1);
            cols[j] = diag1[i + j] = diag2[j - i + n - 1] = false;
            board[i][j] = '.';
        }
    }

    private void constructString()
    {
        var tmp = new List<string>();
        for (int i = 0; i < board.Length; i++)
        {
            tmp.Add(string.Join("", board[i]));
        }
        res.Add(tmp);
    }
}