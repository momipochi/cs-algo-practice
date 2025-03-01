namespace CsAlgoPractice.Leetcode.L994_RottingOranges;

public class RottingOranges
{
    public int OrangesRotting(int[][] grid)
    {
        Queue<(int, int)> q = new Queue<(int, int)>();
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 2)
                {
                    q.Enqueue((i, j));
                } 
            }
        }
        
        int ans = 0;
        IList<(int, int)> tmp = new List<(int, int)>();
        while (q.Count != 0 || tmp.Count != 0)
        {
            while (q.Count != 0)
            {
                var (row, col) = q.Dequeue();
                ModifyOrange(row + 1, col);
                ModifyOrange(row - 1, col);
                ModifyOrange(row, col + 1);
                ModifyOrange(row, col - 1);
                
            }

            if (tmp.Count > 0)
            {
                ans++;
            }
            for (int k = 0; k < tmp.Count; k++)
            {
                q.Enqueue(tmp[k]);        
            }
            tmp.Clear();
        }

        void ModifyOrange(int x, int y)
        {
            if (x < grid.Length && x >= 0 && y <grid[x].Length && y >=0 && grid[x][y] == 1)
            {
                tmp.Add((x,y));
                grid[x][y] = 2;
            }
        }

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 1)
                {
                    return -1;
                }
            }
        }
        return ans;
    }
}