namespace Leetcode;

public class SubsetsSolution
{
    public IList<IList<int>> Subsets(int[] nums)
    {
        IList<IList<int>> res = [];
        res.Add([]);

        for (int i = 0; i < nums.Length; i++)
        {
            int size = res.Count;
            for (int j = 0; j < size; j++)
            {
                IList<int> tmp = new List<int>(res[j])
                {
                    nums[i]
                };
                res.Add(tmp);
            }
        }
        int t = 10;
        testing(ref t);
        return res;
    }
    public void testing(ref int fuck)
    {
        fuck = 20;
    }
}