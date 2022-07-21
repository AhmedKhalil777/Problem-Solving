namespace HackerRank.Algorithms.Tests;

public class CountingValleys
{
    [Fact]
    public void countingValleys_GivenSteps_ShouldReturnExpectedValleys()
    {
        Algorithms.CountingValleys.countingValleys(8 , @"DDUUUUDD")
            .Should().Be(1);
        Algorithms.CountingValleys.countingValleys(8 , @"UDDDUDUU")
            .Should().Be(1);
    }
}