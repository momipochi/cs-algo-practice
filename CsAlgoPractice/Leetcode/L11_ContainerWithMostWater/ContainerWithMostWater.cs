namespace CsAlgoPractice.Leetcode.L11_ContainerWithMostWater;

public class ContainerWithMostWater
{
    public int MaxArea(int[] height)
    {
        int l = 0, r = height.Length - 1, max = 0;

        
        while (l < r)
        {
            int curr = r - l;
            if (height[r] > height[l])
            {
                curr *= height[l];
                l++;
            }
            else
            {
                curr *= height[r];
                r--;
            }
            max = Math.Max(max, curr);
        }
        
        return max;
    }
}