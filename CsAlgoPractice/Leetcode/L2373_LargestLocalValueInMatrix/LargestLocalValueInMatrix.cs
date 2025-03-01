namespace CsAlgoPractice.Leetcode.L2373_LargestLocalValueInMatrix;

public class LargestLocalValueInMatrix
{
    public int[][] LargestLocal(int[][] grid)
    {
        int resSize = grid.Length - 2;
        int[][] res = new int[resSize][];

        for (int i = 0; i < resSize; i++)
        {
            res[i] = new int[resSize];
            for (int g = 0; g < resSize; g++)
            {
                for (int j = i; j < i+3; j++)
                {
                    for (int k = g; k < g+3; k++)
                    {
                        res[i][g] = Math.Max(res[i][g],grid[j][k]);
                    }
                }    
            }
            
        }
        return res;
    }
}