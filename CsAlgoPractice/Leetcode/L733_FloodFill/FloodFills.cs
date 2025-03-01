namespace CsAlgoPractice.Leetcode.L733_FloodFill;

public class FloodFills
{
    public int[][] FloodFill(int[][] image, int sr, int sc, int color)
    {
        int originalColor = image[sr][sc];
        void dfs(int x, int y)
        {
            if (x >= image.Length || x < 0 || y >= image[0].Length  || y < 0 || image[x][y] != originalColor || image[x][y] == color)
            {
                return;
            }
            image[x][y] = color;
            dfs(x+1,y);
            dfs(x-1,y);
            dfs(x,y+1);
            dfs(x,y-1);
            
        }
        dfs(sr,sc);
        return image;
    }
}