namespace CsAlgoPractice.Leetcode.L1413_MinimumValueToGetPositiveStepByStepSum;

public class MinimumValueToGetPositiveStepByStepSum
{
    public int MinStartValue(int[] nums)
    {
        int sum = 0, min = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            if (min > sum)
            {
                min = sum;
            }
        }
        return -min+1;
    }
}