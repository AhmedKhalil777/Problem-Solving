using FluentAssertions;

namespace HackerRank.DataStructures.Tests;

public class LeftRotation
{
    [Fact]
    public void rotateLeft_GivenListsAndSteps_ShouldBeRotatedAsExpected()
    {
        DataStructures.LeftRotation.rotateLeft(4, "1 2 3 4 5".AsStringIntList())
            .Should().Equal("5 1 2 3 4".AsStringIntList());
    }
}