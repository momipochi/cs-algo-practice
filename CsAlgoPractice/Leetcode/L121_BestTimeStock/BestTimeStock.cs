namespace CsAlgoPractice.Leetcode.L121_BestTimeStock;

public class BestTimeStock
{
    public int MaxProfit(int[] prices)
    {
        int max = 0;
        int min = prices[0];
        for (int i = 1; i < prices.Length; i++)
        {
            if (min > prices[i])
            {
                min = prices[i];
            }

            max = Math.Max(max, prices[i] - min);
        }
        return max;
    }
}