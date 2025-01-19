namespace CsAlgoPractice.Leetcode.L39_CombinationSum;

public class CombinationSum
{
    private int[] candidates;
    int target;
    IList<IList<int>> combinations = new List<IList<int>>();
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        this.candidates = candidates;
        this.target = target;
        return combinations;
    }

    private void Search(IList<int> comb, int sum, int index)
    {
        if (sum == target)
        {
            combinations.Add(new List<int>(comb));
            return;
        }
        if (sum > target)
        {
            return;
        }
        comb.Add(candidates[index]);
        Search(comb, sum+candidates[index], index);
        comb.Remove(comb.Count-1);
        Search(comb, sum, index+1);
    }
    
}