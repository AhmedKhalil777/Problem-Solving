

namespace HackerRank.Algorithms.Tests;

public class CircularArrayRotation
{
    [Fact]
    public void CircularArrayRotation_GiveMultiSetOfInputs_ShoudReturnExpectedResults()
    {
        Algorithms.CircularArrayRotation
            .circularArrayRotation(new List<int> { 3, 4, 5 }, 2, new List<int> { 1, 2 })
            .Should().Equal(new List<int> { 5, 3 });
    }

    [Fact]
    public void CircularArrayRotation_GiveBatchOfInputs_ShoudReturnExpectedResults()
    {
        var input = "./C/CircularArrayRotationBatch.txt".ReadLinesAsMatrix();
        var k = input[0][1];
        var a = input[1];
        var q = input.Skip(2).Take(100).SelectMany(x => x).ToList();
        var expected = input.Skip(102).Take(100).SelectMany(x => x).ToList();
        Algorithms.CircularArrayRotation
            .circularArrayRotation(a, k, q)
            .Should().Equal(expected);
    }
}
