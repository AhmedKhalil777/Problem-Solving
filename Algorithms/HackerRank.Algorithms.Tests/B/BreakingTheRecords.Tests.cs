namespace HackerRank.Algorithms.Tests;

public class BreakingTheRecords
{
    [Fact]
    public void breakingRecords_GivenRecords_ShouldReturnMaxMin()
    {
        Algorithms.BreakingTheRecords
            .breakingRecords(new List<int> {10, 5 ,20 ,20 ,4, 5 ,2, 25 ,1 })
            .Should()
            .Equal(new List<int>{2,4});
    }
}