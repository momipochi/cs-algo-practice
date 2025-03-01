namespace CsAlgoPractice.Leetcode.L54_SpiralMatrix;

public class SpiralMatrix
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        IList<int> res = new List<int>();

        int rowStart = 0, rowEnd = matrix.Length - 1;
        int colStart = 0, colEnd = matrix[0].Length-1;
        while (rowStart <= rowEnd && colStart <= colEnd)
        {
            for (int i = colStart; i <= colEnd; i++)
            {
                res.Add(matrix[rowStart][i]);
            }
            rowStart++;
            if (rowStart > rowEnd) break;
            for (int i = rowStart; i <= rowEnd; i++)
            {
                res.Add(matrix[i][colEnd]);
            }

            colEnd--;
            if (colStart > colEnd) break;

            for (int i = colEnd; i >= colStart; i--)
            {
                res.Add(matrix[rowEnd][i]);
            }

            rowEnd--;
            if (rowStart > rowEnd) break;
            for (int i = rowEnd; i >= rowStart; i--)
            {
                res.Add(matrix[i][colStart]);
            }
            colStart++;
            if (colStart > colEnd) break;
        }
        
        return res;
    }
}