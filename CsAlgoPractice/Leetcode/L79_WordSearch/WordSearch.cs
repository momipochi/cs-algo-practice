namespace Leetcode;

public class WordSearchSolution
{
    char[][] board = [];
    string word = "";
    bool[][] used = [];
    public bool Exist(char[][] board, string word)
    {
        this.board = board;
        this.word = word;
        used = Array.ConvertAll(new bool[board.Length], x => new bool[board[0].Length]);
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                if (board[i][j] == word[0] && existsWord(i, j, 0))
                {
                    return true;
                }
            }
        }
        return false;
    }

    private bool existsWord(int x, int y, int index)
    {
        if (index >= word.Length)
        {
            return true;
        }
        if (x < 0 || y < 0 || x >= board.Length || y >= board[x].Length || used[x][y] || word[index] != board[x][y])
        {
            return false;
        }
        used[x][y] = true;
        bool res =
        existsWord(x + 1, y, index + 1) ||
        existsWord(x - 1, y, index + 1) ||
        existsWord(x, y + 1, index + 1) ||
        existsWord(x, y - 1, index + 1);

        used[x][y] = false;
        return res;
    }
}