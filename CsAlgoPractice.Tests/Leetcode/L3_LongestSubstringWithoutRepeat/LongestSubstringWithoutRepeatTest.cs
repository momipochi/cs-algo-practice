using CsAlgoPractice.Leetcode.L3_LongestSubstringWithoutRepeat;
using JetBrains.Annotations;

namespace CsAlgoPractice.Tests.Leetcode.L3_LongestSubstringWithoutRepeat;

[TestSubject(typeof(LongestSubstringWithoutRepeat))]
public class LongestSubstringWithoutRepeatTest
{

    [Fact]
    public void METHOD()
    {
        LongestSubstringWithoutRepeat c = new LongestSubstringWithoutRepeat();
        var input = "abcabcbb";
        var output = 3;
        Assert.Equal(3, c.LengthOfLongestSubstring(input));
    }
}