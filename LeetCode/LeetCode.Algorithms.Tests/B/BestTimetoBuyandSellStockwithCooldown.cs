using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Tests;

public class BestTimetoBuyandSellStockwithCooldown
{
    [Fact]
    public void MaxProfit()
    {
        Algorithms.BestTimetoBuyandSellStockwithCooldown.MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 })
            .Should().Be(5);   
        Algorithms.BestTimetoBuyandSellStockwithCooldown.MaxProfit(new int[] { 7, 6, 4, 3, 1 })
            .Should().Be(0);
    }
}
