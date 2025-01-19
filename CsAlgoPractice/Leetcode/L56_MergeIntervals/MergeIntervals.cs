namespace CsAlgoPractice.Leetcode.L56_MergeIntervals;

public class MergeIntervals
{
    public int[][] Merge(int[][] intervals)
    {
        Array.Sort(intervals, (a,b)=>a[0]-b[0]);
        IList<int[]> res = new List<int[]>();
        int[] prev = intervals[0];
        for (int i = 0; i < intervals.Length; i++)
        {
            if (prev[1] < intervals[i][0])
            {
                res.Add(prev);
                prev = intervals[i];
            }
            else
            {
                prev[1] = prev[1] > intervals[i][1] ? prev[1] : intervals[i][1];
            }
        }
        res.Add(prev);

        return res.ToArray();
    }
}