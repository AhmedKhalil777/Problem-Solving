namespace HackerRank.Algorithms.Tests;

public class SalesByMatch
{
    [Fact]
    public void sockMerchant_GivenPairsOfSocks_ShouldReturnExpectedNumOfPairs()
    {
        Algorithms.SalesByMatch.sockMerchant(9, new List<int>{10, 20, 20, 10, 10, 30, 50, 10, 20})
            .Should().Be(3);
    }
}