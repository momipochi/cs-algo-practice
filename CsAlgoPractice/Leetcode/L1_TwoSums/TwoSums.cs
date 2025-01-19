namespace Leetcode;
public class TwoSums
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int diff = target - nums[i];
            if (dict.ContainsKey(diff))
            {
                return [dict[diff], i];
            }

            dict[nums[i]] = i;
        }
        return [];
    }
}