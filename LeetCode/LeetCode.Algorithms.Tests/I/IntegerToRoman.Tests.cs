namespace LeetCode.Algorithms.Tests;

public class IntegerToRoman
{
    [Fact]
    public void IntToRomanTest()
    {
        Algorithms.IntegerToRoman.IntToRoman(1994)
            .Should().Be("MCMXCIV");
        Algorithms.IntegerToRoman.IntToRoman(10)
            .Should().Be("X");
    }
}
