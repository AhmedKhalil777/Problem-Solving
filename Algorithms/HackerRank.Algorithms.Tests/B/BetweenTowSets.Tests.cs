namespace HackerRank.Algorithms.Tests;

public class BetweenTowSets
{
    [Fact]
    public void getTotalX_GivenTowSets_ShouldReturnBetweenAsExpected1()
    {
        Algorithms.BetweenTowSets
            .getTotalX(new List<int> { 2, 4 }, new List<int> { 16, 32, 96 })
            .Should()
            .Be(3);
    }
    
    [Fact]
    public void getTotalX_GivenTowSets_ShouldReturnBetweenAsExpected2()
    {
        Algorithms.BetweenTowSets
            .getTotalX(new List<int> { 3, 4 }, new List<int> { 24, 48 })
            .Should()
            .Be(2);
    }
}