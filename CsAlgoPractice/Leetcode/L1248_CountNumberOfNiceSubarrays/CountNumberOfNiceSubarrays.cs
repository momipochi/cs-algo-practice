namespace CsAlgoPractice.Leetcode.L1248_CountNumberOfNiceSubarrays;

public class CountNumberOfNiceSubarrays
{
    public int NumberOfSubarrays(int[] nums, int k)
    {
        int[] map = new int[nums.Length + 1];
        map[0] = 1;
        int count = 0, res = 0;

        foreach (int num in nums)
        {
            count += num & 1;
            if (count >= k)
            {
                res += map[count - k];
            }

            map[count]++;
        }
        return res;
    }
}