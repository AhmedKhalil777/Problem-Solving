namespace HackerRank.Algorithms.Tests;

public class ViralAdvertising
{
    [Fact]
    public void viralAdvertising_GiverNDays_ShouldReturnCumulativeLikes()
    {
        Algorithms.ViralAdvertising.viralAdvertising(5).Should().Be(24);
        Algorithms.ViralAdvertising.viralAdvertising(3).Should().Be(9);
    }
}