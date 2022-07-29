using FluentAssertions;

namespace HackerRank.DataStructures.Tests;

public class ArrayManipulation
{
    [Fact]
    public void arrayManipulation_GivenListOfQueries_ShouldReturnMaxOccur()
    {
        DataStructures.ArrayManipulation.arrayManipulation(10000000, "./A/arrayManipulations1.txt".ReadLinesAsMatrix())
            .Should().Be(2510535321);
        DataStructures.ArrayManipulation.arrayManipulation(10000000, "./A/arrayManipulations2.txt".ReadLinesAsMatrix())
            .Should().Be(2506721627);
    }
}