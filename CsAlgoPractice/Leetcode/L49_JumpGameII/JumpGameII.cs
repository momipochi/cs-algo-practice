namespace CsAlgoPractice.Leetcode.L49_JumpGameII;

public class JumpGameII
{
    private int ans = 0;
    private int[] nums;
    public int Jump(int[] nums)
    {
        this.nums = nums;
        int i = 0;
        while (i < nums.Length-1)
        {
            i = NextIndex(i, nums[i]);
        }
        return ans;
    }

    private int NextIndex(int start, int end)
    {
        ans++;
        if (start + end >= nums.Length-1)
        {
            return nums.Length;
        }

        int max = 0, maxIndex = 0;
        for (int i = start; i <= start+end; i++)
        {
            int tmp = nums[i]+i;
            if (tmp > max)
            {
                max = tmp;
                maxIndex = i;
            }
        }
        return maxIndex;
    }
}