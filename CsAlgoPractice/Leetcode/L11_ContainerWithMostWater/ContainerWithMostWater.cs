namespace CsAlgoPractice.Leetcode.L11_ContainerWithMostWater;

public class ContainerWithMostWater
{
    public int MaxArea(int[] height)
    {
        int l = 0, r = height.Length-1;
        int max = 0;
        while (l < r)
        {
            var diff = r - l;
            if (height[l] > height[r])
            {
                max = Math.Max(max, diff * height[r]);
                r--;
            }
            else
            {
                max = Math.Max(max, diff * height[l]);
                l++;
            }
        }
        return max;
    }
}