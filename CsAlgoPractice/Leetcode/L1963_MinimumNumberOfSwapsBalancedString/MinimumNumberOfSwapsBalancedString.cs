namespace CsAlgoPractice.Leetcode.L1963_MinimumNumberOfSwapsBalancedString;

public class MinimumNumberOfSwapsBalancedString
{
    public int MinSwaps(string s)
    {
        int open = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '[')
            {
                open++;
            }
            else if(open >0)
            {
                open--;
            }
        }
        return (open + 1)/2;
    }
}