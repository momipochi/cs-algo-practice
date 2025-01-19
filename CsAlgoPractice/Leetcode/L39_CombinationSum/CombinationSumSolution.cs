namespace CsAlgoPractice.Leetcode.L39_CombinationSum;

public class CombinationSumSolution
{
    private int[] candidates;
    int target;
    IList<IList<int>> res = new List<IList<int>>();
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        this.candidates = candidates;
        this.target = target;
        Search(new List<int>(), 0,0);
        return res;
    }

    private void Search(IList<int> comb, int sum, int index)
    {
        if (sum == target)
        {
            res.Add(new List<int>(comb));
            return;
        }
        if (sum > target || index >= candidates.Length)
        {
            return;
        }

        comb.Add(candidates[index]);
        Search(comb, sum+candidates[index], index);
        comb.RemoveAt(comb.Count-1);
        Search(comb, sum, index+1);
    }
    
}