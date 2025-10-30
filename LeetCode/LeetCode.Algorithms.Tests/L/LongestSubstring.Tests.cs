namespace LeetCode.Algorithms.Tests;

public class LongestSubstring
{

    [Fact]
    public void LengthOfLongestSubstring_GivenMultiSet_ShouldReturnExpectedRes()
    {
        Algorithms.LongestSubstring.LengthOfLongestSubstring("abcabcbb")
            .Should().Be(3);
        Algorithms.LongestSubstring.LengthOfLongestSubstring("bbbbb")
             .Should().Be(1);
        Algorithms.LongestSubstring.LengthOfLongestSubstring("pwwkew")
             .Should().Be(3);
        Algorithms.LongestSubstring.LengthOfLongestSubstring("dvdf")
            .Should().Be(3);
    }   
}
