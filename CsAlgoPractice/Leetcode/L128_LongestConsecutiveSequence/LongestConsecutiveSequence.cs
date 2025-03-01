namespace CsAlgoPractice.Leetcode.L128_LongestConsecutiveSequence;

public class LongestConsecutiveSequence
{
    public int LongestConsecutive(int[] nums)
    {
        var set = new HashSet<int>(nums);
        int max = 0;
        
        foreach (var num in set)
        {
            if (set.Contains(num-1))
            {
                continue;
            }
            int count = 0;
            while (set.Contains(num+count))
            {
                count++;
            }
            max = Math.Max(max, count);

        }
        
        return max;
    }
}