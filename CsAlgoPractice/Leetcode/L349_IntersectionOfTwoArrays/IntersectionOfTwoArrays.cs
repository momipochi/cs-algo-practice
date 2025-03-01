namespace CsAlgoPractice.Leetcode.L349_IntersectionOfTwoArrays;

public class IntersectionOfTwoArrays
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        HashSet<int> res = new HashSet<int>();
        IDictionary<int, bool> d = new Dictionary<int, bool>();
        for (int i = 0; i < nums1.Length; i++)
        {
            if (!d.ContainsKey(nums1[i]))
            {
                d[nums1[i]] = true;
            }
        }

        for (int i = 0; i < nums2.Length; i++)
        {
            if (d.ContainsKey(nums2[i]))
            {
                res.Add(nums2[i]);
            }
        }
        return res.ToArray();
    }
}