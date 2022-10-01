namespace HackerRank.Algorithms.Tests;

public class SherlockAndSquares
{
    [Fact]
    public void SherlockAndSquares_GivenMultiSet_ShouldRetunNumOfSquares()
    {
        Algorithms.SherlockAndSquares.squares(3,9).Should().Be(2);
        Algorithms.SherlockAndSquares.squares(17,24).Should().Be(0);
    }
}
