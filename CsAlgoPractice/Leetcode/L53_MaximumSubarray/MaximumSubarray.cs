namespace CsAlgoPractice.Leetcode.L53_MaximumSubarray;

public class MaximumSubarray
{
    public int MaxSubArray(int[] nums)
    {
        int sum = nums[0], max = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (sum < 0)
            {
                sum = 0;
            }
            sum += nums[i];
            max = Math.Max(max, sum);
        }

        return max;   
    }
}