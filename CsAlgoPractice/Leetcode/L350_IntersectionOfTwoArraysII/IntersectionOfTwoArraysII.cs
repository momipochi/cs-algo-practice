namespace CsAlgoPractice.Leetcode.L350_IntersectionOfTwoArraysII;

public class IntersectionOfTwoArraysII
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        IDictionary<int, int> d1 = new Dictionary<int, int>();
        IDictionary<int, int> d2 = new Dictionary<int, int>();
        foreach (var num in nums1)
        {
            if (d1.ContainsKey(num))
            {
                d1[num]++;
            }
            else
            {
                d1[num] = 1;
            }
        }
        foreach (var num in nums2)
        {
            if (d2.ContainsKey(num))
            {
                d2[num]++;
            }
            else
            {
                d2[num] = 1;
            }
        }

        IList<int> res = new List<int>();
        foreach (var d in d1)
        {
            if (d2.ContainsKey(d.Key) )
            {
                while (d2[d.Key] != 0 && d1[d.Key] != 0)
                {
                    res.Add(d.Key);
                    d1[d.Key]--;
                    d2[d.Key]--;
                }
            }
        }
        return res.ToArray();
    }
}