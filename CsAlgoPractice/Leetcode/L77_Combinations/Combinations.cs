namespace CsAlgoPractice.Leetcode.L77_Combinations;

public class Combinations
{
    public IList<IList<int>> Combine(int n, int k)
    {
        IList<IList<int>> res = new List<IList<int>>();
        Search(1,n,k,new List<int>(),res);
        return res;
    }

    private void Search(int index, int n, int k, List<int> comb, IList<IList<int>> res)
    {
        if (k == 0)
        {
            res.Add(new List<int>(comb));
            return;
        }

        for (int i = index; i <= n; i++)
        {
            comb.Add(i);
            Search(i+1,n,k-1,comb,res);
            comb.RemoveAt(comb.Count-1);
        }
    }
}