namespace CsAlgoPractice.Leetcode.L532_KDiffPairsInArray;

public class KDiffPairsInArray
{
    public int FindPairs(int[] nums, int k)
    {
        Dictionary<int,int> d = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (d.ContainsKey(nums[i]))
            {
                d[nums[i]]++;
            }
            else
            {
                d[nums[i]] = 1;
            }
        }

        var res = 0;
        foreach (var p in d)
        {
            var key = p.Key;
            var val = p.Value;

            if (k > 0 && d.ContainsKey(key - k))
            {
                res++;
            }else if (k == 0 && val > 1) res++;
        }

        return res;
    }
}