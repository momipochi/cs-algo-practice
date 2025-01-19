using CsAlgoPractice.Leetcode.L39_CombinationSum;
using JetBrains.Annotations;

namespace CsAlgoPractice.Tests.Leetcode.L39_CombinationSum;

[TestSubject(typeof(CombinationSumSolution))]
public class CombinationSumSolutionTest
{

    [Fact]
    public void METHOD()
    {
        CombinationSumSolution obj = new CombinationSumSolution();
        int[] candidates = [2, 3, 6, 7];
        int target = 7;
        int[][] output = [[2, 2, 3], [7]];
        var tmp = obj.CombinationSum(candidates, target);
        Assert.Equal(output,tmp.Select(x => x.ToArray()).ToArray());
    }
}