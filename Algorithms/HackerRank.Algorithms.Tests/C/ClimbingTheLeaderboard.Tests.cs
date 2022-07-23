namespace HackerRank.Algorithms.Tests;

public class ClimbingTheLeaderboard
{
    [Fact]
    public void climbingLeaderboard_GivenRankedWithPlayer_ShouldReturnExpectedRanks()
    {
        Algorithms.ClimbingTheLeaderboard
            .climbingLeaderboardV1(new List<int> { 100, 90, 90, 80 }, new List<int> { 70, 80, 105 })
            .Should().Equal(new List<int> {4, 3,1 });
        
        Algorithms.ClimbingTheLeaderboard
            .climbingLeaderboardV2(new List<int> { 100, 90, 90, 80 }, new List<int> { 70, 80, 105 })
            .Should().Equal(new List<int> {4, 3, 1 });
    }
}