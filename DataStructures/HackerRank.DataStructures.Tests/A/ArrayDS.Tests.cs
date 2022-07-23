using FluentAssertions;
using HackerRank.Utilities;

namespace HackerRank.DataStructures.Tests;

public class ArrayDS
{
    [Fact]
    public void reverseArray_GivenArray_ShouldReturnReverse()
    {
        DataStructures.ArrayDS.reverseArray("1 4 3 2".AsStringIntList()).Should().Equal("2 3 4 1".AsStringIntList());
    }
}