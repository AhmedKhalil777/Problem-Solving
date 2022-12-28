namespace LeetCode.Algorithms;

public static class BestTimetoBuyandSellStockwithCooldown
{
    public static int MaxProfit(int[] prices)
    {
        var minimum = prices[0];
        var maxProfit = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            minimum = Math.Min(minimum, prices[i]);
            maxProfit = Math.Max(maxProfit, prices[i] - minimum);
        }
        return maxProfit;
    }
}
