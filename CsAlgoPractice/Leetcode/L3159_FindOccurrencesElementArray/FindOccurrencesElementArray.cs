namespace CsAlgoPractice.Leetcode.L3159_FindOccurrencesElementArray;

public class FindOccurrencesElementArray
{
    public int[] OccurrencesOfElement(int[] nums, int[] queries, int x)
    {
        int[] ans = new int[nums.Length ];

        int c = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            ans[i] = -1;
            if (x == nums[i])
            {
                ans[c] = i;
                c++;
            }
        }
        
        int[] res = new int[queries.Length];
        int ix = 0;
        for (int i = 0;i<queries.Length;i++)
        {
            int q = queries[i];
            if (ans.Length <= q-1)
            {
                res[ix] = -1;
            }
            else
            {
                res[ix] = ans[q - 1];
            }
            ix++;
        }
        
        return res;
    }
}