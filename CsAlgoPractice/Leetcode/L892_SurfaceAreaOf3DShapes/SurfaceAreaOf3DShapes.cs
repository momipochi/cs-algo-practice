namespace CsAlgoPractice.Leetcode.L892_SurfaceAreaOf3DShapes;

public class SurfaceAreaOf3DShapes
{
    public int SurfaceArea(int[][] grid)
    {
        int vFace = 0, hFace = 0, tFace = 0;

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 0)
                {
                    continue;
                }
                vFace += grid[i][j] - 1;
                tFace += grid[i][j] * 6;
                if (i+1 < grid.Length)
                {
                    int v1 = grid[i][j], v2 = grid[i+1][j];
                    if (v1 != 0 && v2 != 0)
                    {
                        if (v1 > v2)
                        {
                            hFace += v1 - (v1 - v2);
                        }
                        else
                        {
                            hFace += v2 - (v2 - v1);
                        }
                    }
                    
                }
                if (j+1 < grid[i].Length)
                {
                    int v1 = grid[i][j], v2 = grid[i][j+1];
                    if (v1 != 0 && v2 != 0)
                    {
                        if (v1 > v2)
                        {
                            hFace += v1 - (v1 - v2);
                        }
                        else
                        {
                            hFace += v2 - (v2 - v1);
                        }
                    }

                    
                }

                
            }
        }
        
        return tFace - (vFace * 2 + hFace * 2);
    }
}