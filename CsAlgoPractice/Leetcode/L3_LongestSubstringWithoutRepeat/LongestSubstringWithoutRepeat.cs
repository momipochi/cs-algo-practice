namespace CsAlgoPractice.Leetcode.L3_LongestSubstringWithoutRepeat;

public class LongestSubstringWithoutRepeat
{
    public int LengthOfLongestSubstring(string s)
    {
        int left = 0, right = 0, max = 0;

        while (right < s.Length)
        {
            var newLeft = NewLeft(s[right], left, right);
            if (newLeft != 0)
            {
                left += newLeft;
            }
            right++;
            max = Math.Max(max,right-left);
        }
        int NewLeft(char c, int start, int end)
        {
            int count = 1;
            for (int i = start; i < end; i++)
            {
                if (c == s[i])
                {
                    return count;
                }
                count++;
            }
            return 0;
        }
        return max;
    }
    
}