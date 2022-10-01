namespace HackerRank.Algorithms.Tests;

public class CutTheSticks
{
    [Fact]
    public void CutTheSticks_GivenMultiSetOfSticks_ShouldReturnNumOfPieces()
    {
        Algorithms.CutTheSticks.cutTheSticks(new List<int> { 5, 4, 4, 2, 2, 8 }).Should().Equal(new List<int> { 6, 4, 2, 1});
        Algorithms.CutTheSticks.cutTheSticks(new List<int> { 1, 2 ,3, 4, 3, 3, 2, 1 }).Should().Equal(new List<int> { 8,6,4,1});
    }
}
