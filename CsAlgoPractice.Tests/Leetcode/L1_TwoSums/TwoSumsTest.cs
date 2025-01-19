using JetBrains.Annotations;
using Leetcode;

namespace CsAlgoPractice.Tests.Leetcode.L1_TwoSums;

[TestSubject(typeof(TwoSums))]
public class TwoSumsTest
{

    [Fact]
    public void TWO_SUM()
    {
        int[] nums = [2, 7, 11, 15];
        int[] ans = [0, 1];
        int target = 9;
        TwoSums obj = new TwoSums();
        Assert.Equal(ans, obj.TwoSum(nums, target));
    }
}