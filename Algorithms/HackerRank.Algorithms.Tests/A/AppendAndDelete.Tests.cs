namespace HackerRank.Algorithms.Tests;

public class AppendAndDelete
{
    [Fact]
    public void AppendAndDelete_GivenMultiSet_ShouldReturnExpected()
    {
        Algorithms.AppendAndDelete.appendAndDelete("hackerhappy", "hackerrank", 9).Should().Be("Yes");
        Algorithms.AppendAndDelete.appendAndDelete("aba", "aba", 7).Should().Be("Yes");
        Algorithms.AppendAndDelete.appendAndDelete("ashley", "ash", 2).Should().Be("No");
    }
}
