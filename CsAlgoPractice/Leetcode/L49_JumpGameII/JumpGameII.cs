namespace CsAlgoPractice.Leetcode.L49_JumpGameII;

public class JumpGameII
{
    public int Jump(int[] nums)
    {
        int index = 0, ans = 0;
        while (index < nums.Length-1)
        {
            index = NextIndex(index, nums[index]);
        }

        int NextIndex(int start, int end)
        {
            ans++;
            if (start + end >= nums.Length-1)
            {
                return nums.Length;
            }

            int max = 0, maxPos = 0;
            for (int i = start; i <= start+end; i++)
            {
                int dist = nums[i] + i;
                if (dist > max)
                {
                    max = dist;
                    maxPos = i;
                }
            }
            return maxPos;
        }

        return ans;
    }

}