namespace HackerRank.Algorithms.Tests;

public class RepeatedString
{
    [Fact]
    public void repeatedString_GivenMultiSet_ShouldReturnExpected()
    {
        Algorithms.RepeatedString.repeatedString("aba",10).Should().Be(7);
        Algorithms.RepeatedString.repeatedString("a", 1000000000000).Should().Be(1000000000000);
    }
}
