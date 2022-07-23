namespace HackerRank.Algorithms.Tests;

public class HurdleRace
{
    [Fact]
    public void hurdleRace_GivenMaxAndHurdles_ShouldReturnNumOfDoses()
    {
        Algorithms.HurdleRace.hurdleRace(7, new List<int> { 2, 5, 4, 5, 2 }).Should().Be(0);
        Algorithms.HurdleRace.hurdleRace(4, new List<int> { 1 ,6 ,3, 5 ,2 }).Should().Be(2);
    }
}