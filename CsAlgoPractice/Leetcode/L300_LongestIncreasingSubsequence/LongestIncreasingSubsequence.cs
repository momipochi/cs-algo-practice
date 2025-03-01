namespace CsAlgoPractice.Leetcode.L300_LongestIncreasingSubsequence;

public class LongestIncreasingSubsequence
{
    public int LengthOfLIS(int[] nums)
    {
        int max = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            int counter = 1;
            for (int j = i+1; j < nums.Length; j++)
            {
                if (nums[j] < nums[i])
                {
                    max = Math.Max(max, counter);
                    break;
                }
                counter++;
            }
        }
        return max;
    }
}