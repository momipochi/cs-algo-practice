namespace CsAlgoPractice.Leetcode.L566_ReshapeTheMatrix;

public class ReshapeTheMatrix
{
    public int[][] MatrixReshape(int[][] mat, int r, int c)
    {
        if (r*c != mat.Length*mat[0].Length)
        {
            return mat;
        }

        int[][] res = new int [r][];
        for (int i = 0; i < res.Length; i++)
        {
            res[i] = new int[c];
        }
        int row = 0, col = 0;
        for (int i = 0; i < mat.Length; i++)
        {
            for (int j = 0; j < mat[0].Length; j++)
            {
                res[row][col] = mat[i][j];
                col++;

                if (col+1 == res[0].Length)
                {
                    col = 0;
                    row++;
                }
            }
        }
        
        return res;
    }
}