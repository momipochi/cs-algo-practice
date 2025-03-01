namespace CsAlgoPractice.Leetcode.L983_MinimumCostForTickets;

public class MinimumCostForTickets
{
    public int MincostTickets(int[] days, int[] costs)
    {
        var maxDay = days[^1];
        var isTravelDay = new bool[maxDay+1];
        foreach (var day in days)
        {
            isTravelDay[day] = true;
        }
        
        var dp = new int[maxDay+1];
        dp[0] = 0;

        for (int i = 1; i <= maxDay; i++)
        {
            if (!isTravelDay[i])
            {
                dp[i] = dp[i - 1];
            }
            else
            {
                var cost1 = dp[i - 1] + costs[0];
                var cost7 = dp[Math.Max(0,i-7)] + costs[1];
                var cost30 = dp[Math.Max(0,i-30)] + costs[2];
                dp[i] = Math.Min(cost1, Math.Min(cost7, cost30));
            }
        }

        return dp[^1];
    }
}