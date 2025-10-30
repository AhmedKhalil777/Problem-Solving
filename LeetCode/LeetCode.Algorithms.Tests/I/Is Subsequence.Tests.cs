using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Tests;

public class Is_Subsequence
{

    [Theory]
    [InlineData("abc", "ahbgdc", true)]
    [InlineData("axc", "ahbgdc", false)]
    [InlineData("aec", "abcde", false)]
    [InlineData("", "ahbgdc", true)]
    public void IsSubsequence(string s, string t, bool res)
    {
        new Algorithms.Is_Subsequence().IsSubsequence(s, t).Should().Be(res);
    }
}
