namespace CsAlgoPractice.Leetcode.L121_BestTimeStock;

public class BestTimeStock
{
    public int MaxProfit(int[] prices)
    {
        int max = 0, min = prices[0];

        for (int i = 0; i < prices.Length; i++)
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