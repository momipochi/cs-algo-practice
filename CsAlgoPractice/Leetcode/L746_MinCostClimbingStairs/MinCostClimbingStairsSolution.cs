namespace CsAlgoPractice.Leetcode.L746_MinCostClimbingStairs;

public class MinCostClimbingStairsSolution
{
    public int MinCostClimbingStairs(int[] cost)
    {
        if (cost.Length < 3) return Math.Min(cost[0], cost[1]);

        for (int i = 2; i < cost.Length; i++)
        {
            cost[i] += Math.Min(cost[i - 1], cost[i - 2]);
        }

        return cost[^1];
    }
}