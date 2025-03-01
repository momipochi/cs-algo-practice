namespace CsAlgoPractice.Leetcode.L73_SetMatrixZeroes;

public class SetMatrixZeroes
{
    public void SetZeroes(int[][] matrix)
    {
        IList<(int, int)> list = new List<(int, int)>();
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] == 0)
                {
                    list.Add((i,j));
                }
            }
        }
        foreach (var d in list)
        {
            int row = d.Item1, col = d.Item2;
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i][col] = 0;
            }
            for (int i = 0; i < matrix[row].Length; i++)
            {
                matrix[row][i] = 0;
            }
            
        }
    }
}