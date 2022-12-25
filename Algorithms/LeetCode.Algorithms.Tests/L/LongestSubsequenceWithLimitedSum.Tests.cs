using System;


namespace LeetCode.Algorithms.Tests;


public class LongestSubsequenceWithLimitedSum
{
    [Fact]
    public void AnswerQueries()
    {
        Algorithms.LongestSubsequenceWithLimitedSum.AnswerQueries(new int[] { 4, 5, 2, 1 }, new int[] { 3, 10, 21 })
            .Should().Equal(new int[] { 2, 3, 4 });
        Algorithms.LongestSubsequenceWithLimitedSum.AnswerQueries(new int[] { 2, 3, 4, 5 }, new int[] { 1 })
            .Should().Equal(new int[] { 0});
    }
}
