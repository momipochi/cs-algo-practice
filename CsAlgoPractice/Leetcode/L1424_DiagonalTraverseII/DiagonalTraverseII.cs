namespace CsAlgoPractice.Leetcode.L1424_DiagonalTraverseII;

public class DiagonalTraverseII
{
    public int[] FindDiagonalOrder(IList<IList<int>> nums)
    {
        Queue<(int, int)> q = new();
        IList<int> res = new List<int>();
        q.Enqueue((0,0));

        while (q.Count>0)
        {
            var (row, col) = q.Dequeue();
            res.Add(nums[row][col]);

            if (col == 0 && row + 1 < nums.Count)
            {
                q.Enqueue((row+1,col));
            }

            if (col + 1 < nums[row].Count)
            {   
                q.Enqueue((row,col+1));
            }
        }
        return res.ToArray();
    }
}