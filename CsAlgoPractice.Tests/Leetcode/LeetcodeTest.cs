namespace Leetcode.Test;

public class LeetcodeTest
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

    [Fact]
    public void TestWordSearch()
    {
        WordSearchSolution ws = new WordSearchSolution();
        char[][] input = [['A', 'B', 'C', 'E'], ['S', 'F', 'C', 'S'], ['A', 'D', 'E', 'E']];
        string word = "ABCCED";
        Assert.True(ws.Exist(input, word));
    }
}