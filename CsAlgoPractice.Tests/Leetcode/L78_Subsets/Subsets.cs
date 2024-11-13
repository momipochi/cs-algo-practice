using L78_Subsets;

namespace Leetcode.Test;

public class SubsetsTest
{
    [Fact]
    public void TestSubset()
    {
        int[] arr = [1, 2, 3];
        var output = Utils.TwoDimensionalArrayToList<int>([[], [1], [2], [1, 2], [3], [1, 3], [2, 3], [1, 2, 3]]);
        // int[,] out = { { }, { 1 }, { 2 }, { 1, 2 }, { 3 }, { 1, 3 }, { 2, 3 }, { 1, 2, 3 } };
        SubsetsSolution ss = new();
        Assert.True(Utils.AreTwoDimensionalListsEqual(ss.Subsets(arr), output));
    }
}