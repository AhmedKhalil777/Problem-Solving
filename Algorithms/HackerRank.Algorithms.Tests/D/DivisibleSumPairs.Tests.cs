namespace HackerRank.Algorithms.Tests;

public class DivisibleSumPairs
{
    [Fact]
    public void divisibleSumPairs_GivenPairs_ShouldReturnCountOfDivisibleSum()
    {
        Algorithms.DivisibleSumPairs.divisibleSumPairs(6, 3, new List<int> { 1, 3, 2, 6, 1, 2 })
            .Should().Be(5);
    }
}