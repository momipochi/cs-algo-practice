namespace CsAlgoPractice.Leetcode.L200_NumberofIslands;

public class NumberofIslands
{
    
    public int NumIslands(char[][] grid)
    {
        int res = 0;
        void Helper(int x, int y)
        {
            if (x < 0 || x >= grid.Length || y < 0 || y >= grid[0].Length || grid[x][y] == '0')
            {
                return;
            }
            grid[x][y] = '0';
            Helper(x , y - 1);
            Helper(x - 1, y );
            Helper(x + 1, y );
            Helper(x , y+1 );
        }

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == '1')
                {
                    res++;
                    Helper(i,j);
                }
            }
        }
        return res;
    }
}