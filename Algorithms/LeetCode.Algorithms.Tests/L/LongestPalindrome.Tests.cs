namespace LeetCode.Algorithms.Tests;

public class LongestPalindrome
{
    [Fact]
    public void LongestPalindromeM()
    {
        Algorithms.LongestPalindrome.LongestPalindromeM("abccccdd").Should().Be(7);
        Algorithms.LongestPalindrome.LongestPalindromeM("a").Should().Be(1);
    }
}
