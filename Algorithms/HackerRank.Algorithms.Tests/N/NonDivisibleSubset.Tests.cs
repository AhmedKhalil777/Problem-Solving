namespace HackerRank.Algorithms.Tests;

public class NonDivisibleSubset
{
    [Fact]
    public void NonDivisibleSubset_GivenMultiSet_ShouldRetunMaxCountOfNonDivisibleSubset()
    {
        Algorithms.NonDivisibleSubset.nonDivisibleSubset(3, new List<int> { 1, 7, 2, 4 }).Should().Be(3);
    }
}
