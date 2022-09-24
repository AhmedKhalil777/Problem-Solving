namespace HackerRank.Algorithms.Tests;

public class SequenceEquation
{

    [Fact]
    public void SequanceEquation_GivenMultiSet_ShouldReturnExpectedResults()
    {
        Algorithms.SequenceEquation
            .permutationEquation(new List<int> { 5, 2, 1, 3, 4 })
            .Should().Equal(new List<int> { 4, 2, 5, 1, 3 });
        Algorithms.SequenceEquation
            .permutationEquation(new List<int> { 2, 3, 1 })
            .Should().Equal(new List<int> { 2, 3, 1 });
    }
}
