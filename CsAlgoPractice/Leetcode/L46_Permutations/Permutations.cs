namespace CsAlgoPractice.Leetcode.L46_Permutations;

public class Permutations
{
    IList<IList<int>> res = new List<IList<int>>();
    private int[] nums;
    public IList<IList<int>> Permute(int[] nums)
    {
        this.nums = nums;
        dfs(new List<int>());
        return res;
    }

    private void dfs(IList<int> perm)
    {
        if (perm.Count == nums.Length)
        {
            res.Add(new List<int>(perm));
            return;
        }
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (perm.Contains(nums[i]))
            {
                continue;
            }
            perm.Add(nums[i]);
            dfs(perm);
            perm.RemoveAt(perm.Count - 1);
        }
    }
}