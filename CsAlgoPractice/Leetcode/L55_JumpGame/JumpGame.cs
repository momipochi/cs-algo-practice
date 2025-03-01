namespace CsAlgoPractice.Leetcode.L55_JumpGame;

public class JumpGame
{
    public bool CanJump(int[] nums)
    {
        int dist = nums[0];
        for (int i = 0; i < nums.Length; i++)
        {
            if (i>dist)
            {
                return false;
            }

            dist = Math.Max(dist, nums[i] + i);
        }
        return true;
    }
}