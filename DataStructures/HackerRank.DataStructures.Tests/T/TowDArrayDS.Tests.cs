using FluentAssertions;
using HackerRank.Utilities;

namespace HackerRank.DataStructures.Tests;

public class TowDArrayDS
{
    [Fact]
    public void hourglassSum_Given6X6Matrix_ShouldReturnMaxHourGlass()
    {
        DataStructures.TowDArrayDS.hourglassSum("./T/6X6MatrixResults19.txt".ReadLinesAsMatrix())
            .Should().Be(19);
        DataStructures.TowDArrayDS.hourglassSum("./T/6X6MatrixResults13.txt".ReadLinesAsMatrix())
            .Should().Be(13);
    }
}