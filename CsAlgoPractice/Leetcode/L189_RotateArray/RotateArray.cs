namespace CsAlgoPractice.Leetcode.L189_RotateArray;

public class RotateArray
{
    public void Rotate(int[] nums, int k) {
        k %= nums.Length;
        Helper(nums, 0, nums.Length-1);
        Helper(nums, 0, k-1);
        Helper(nums, k, nums.Length-1);
    }

    private void Helper(int[] nums, int start, int end)
    {
        while (start < end)
        {
            (nums[start], nums[end]) = (nums[end], nums[start]);
            start++;
            end--;
        }
        
    }
}