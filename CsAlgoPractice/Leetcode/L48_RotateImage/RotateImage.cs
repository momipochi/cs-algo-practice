namespace CsAlgoPractice.Leetcode.L48_RotateImage;

public class RotateImage
{
    public void Rotate(int[][] matrix) {
        var size = matrix.Length;

        for (int i = 0; i < size; i++)
        {
            for (int j = i; j < size; j++)
            {
                int tmp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = tmp;
            }
        }

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size/2; j++)
            {
                int tmp = matrix[i][j];
                matrix[i][j] = matrix[i][size - j - 1];
                matrix[i][size - j - 1] = tmp;
            }
        }
    }
}