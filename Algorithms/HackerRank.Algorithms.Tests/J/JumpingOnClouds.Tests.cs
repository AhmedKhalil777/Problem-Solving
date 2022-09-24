namespace HackerRank.Algorithms.Tests;

public class JumbingOnClouds
{
    [Fact]
    public void JumbingOnClouds_GivenMultSet_ShouldReturnExpectedResults()
    {
        Algorithms.JumpingOnClouds.jumpingOnClouds(new int[] { 0, 0, 1, 0, 0, 1, 1, 0 }, 2)
            .Should().Be(92);
        Algorithms.JumpingOnClouds.jumpingOnClouds(new int[] { 0, 0, 1, 0 }, 2)
        .Should().Be(96);     
        Algorithms.JumpingOnClouds.jumpingOnClouds(new int[] { 1 ,1 ,1 ,0 ,1 ,1 ,0, 0, 0, 0 }, 3)
        .Should().Be(80);
    }
}
