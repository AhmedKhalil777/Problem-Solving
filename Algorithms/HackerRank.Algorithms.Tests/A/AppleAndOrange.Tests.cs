namespace HackerRank.Algorithms.Tests;

public class AppleAndOrange
{
    [Fact]
    public void countApplesAndOranges_GivenExampleData_ShouldReturnSpecifiedOutput()
    {
        var res = Algorithms.AppleAndOrange.countApplesAndOranges(7, 11, 5, 15,
            new List<int> { -2, 2, 1 }, new List<int> { 5, -6 });
        res.Should().Be(new Tuple<int, int>(1, 1));
    }
}