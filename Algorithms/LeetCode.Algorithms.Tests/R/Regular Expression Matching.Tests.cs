namespace LeetCode.Algorithms.Tests;

public class Regular_Expression_Matching
{
    [Theory]
    [InlineData("aa", "a", false)]
    [InlineData("aa", "a*", true)]
    [InlineData("ab", ".*", true)]
    public void IsMatch(string s, string p, bool res)
    {
        new Algorithms.Regular_Expression_Matching()
            .IsMatch(s, p)
            .Should()
            .Be(res);
    }
}