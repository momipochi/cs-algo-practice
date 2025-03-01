namespace CsAlgoPractice.Sourcless;

public class TwoDimensionalArrayTraversal
{
    //TODO learn
    public int solution(int[][] field, int[][] figure)
    {
        int height = field.Length;
        int width = field[0].Length;
        int figureSize = figure.Length;

        // Loop through each column where the figure can fit
        for (int column = 0; column <= width - figureSize; column++)
        {
            int row = 0;
            
            // Loop through the rows to check if the figure can fit
            while (row < height - figureSize + 1)
            {
                bool canFit = true;

                // Check if the figure can fit at the current position
                for (int dx = 0; dx < figureSize; dx++)
                {
                    for (int dy = 0; dy < figureSize; dy++)
                    {
                        if (field[row + dx][column + dy] == 1 && figure[dx][dy] == 1)
                        {
                            canFit = false;
                        }
                    }
                }

                if (!canFit)
                {
                    break;
                }
                row++;
            }
            row--;

            // Check if the figure can be placed in the current position
            for (int dx = 0; dx < figureSize; dx++)
            {
                bool rowFilled = true;

                // Check if each row in the figure is filled
                for (int columnIndex = 0; columnIndex < width; columnIndex++)
                {
                    if (!(field[row + dx][columnIndex] == 1 ||
                          (column <= columnIndex && columnIndex < column + figureSize && figure[dx][columnIndex - column] == 1)))
                    {
                        rowFilled = false;
                    }
                }

                if (rowFilled)
                {
                    return column;
                }
            }
        }

        return -1;
    }
}