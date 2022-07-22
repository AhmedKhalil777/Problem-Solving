namespace HackerRank.Algorithms.Tests;

public class CatsAndAMouse
{
    [Fact]
    public void catAndMouse_GivenDifferentPositions_ShouldReturnTheWinner()
    {
        Algorithms.CatsAndAMouse.catAndMouse(1,2,3)
            .Should().Be("Cat B");
        Algorithms.CatsAndAMouse.catAndMouse(1,3,2)
            .Should().Be("Mouse C");
    }
}