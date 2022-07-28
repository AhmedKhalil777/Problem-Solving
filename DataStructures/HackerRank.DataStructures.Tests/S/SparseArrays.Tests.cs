using FluentAssertions;

namespace HackerRank.DataStructures.Tests;

public class SparseArrays
{
    [Fact]
    public void matchingStrings_GivenManyQueries_ShouldReturnTheCountOfMatching()
    {
        DataStructures.SparseArrays
            .matchingStrings("aba baba aba xzxb".Split(' ').ToList(), "aba xzxb ab".Split(' ').ToList())
            .Should().Equal(new List<int> { 2, 1, 0 });
    }
}