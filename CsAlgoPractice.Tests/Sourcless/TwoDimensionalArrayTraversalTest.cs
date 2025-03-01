using CsAlgoPractice.Sourcless;
using JetBrains.Annotations;

namespace CsAlgoPractice.Tests.Sourcless;

[TestSubject(typeof(TwoDimensionalArrayTraversal))]
public class TwoDimensionalArrayTraversalTest
{

    [Fact]
    public void Solution()
    {
        var field = new int[5][]
        {
            [0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0],
            [0, 0, 0, 0, 0],
            [1, 1, 0, 1, 0],
            [1, 0, 1, 0, 1]
        };
        var figure = new int[3][]
        {
            [1, 1, 1],
            [1, 0, 1],
            [1, 0, 1]
        };
        var ans = new TwoDimensionalArrayTraversal().solution(field, figure);
        Assert.True(ans == 2);
    }
}