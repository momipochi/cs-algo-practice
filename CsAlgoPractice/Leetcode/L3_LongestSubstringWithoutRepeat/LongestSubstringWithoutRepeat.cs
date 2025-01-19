namespace CsAlgoPractice.Leetcode.L3_LongestSubstringWithoutRepeat;

public class LongestSubstringWithoutRepeat
{
    private string ss;
    public int LengthOfLongestSubstring(string s)
    {
        ss = s;
        int max = 0;
        int left = 0, right = 0;
        while (right < s.Length)
        {
            int newLeft = NewLeft(s[right],left,right);
            if (newLeft != 0)
            {
                left += newLeft;
            }
            right++;
            int tmp = right - left;
            max = max > tmp ? max : tmp;
        }
        return max;
    }

    private int NewLeft(char left, int start, int end)
    {
        int count = 1;
        for (int i = start; i < end; i++)
        {
            if (left == ss[i])
            {
                return count;
            }
            count++;
        }
        return 0;
    }
    
}