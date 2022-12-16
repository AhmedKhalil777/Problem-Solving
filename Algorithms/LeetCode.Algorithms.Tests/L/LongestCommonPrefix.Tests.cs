using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Tests;

public class LongestCommonPrefix
{
    [Fact]
    public void LongestCommonPrefixM_GivenMultiSet_ShouldReturnExpectedRes()
    {
        Algorithms.LongestCommonPrefix.LongestCommonPrefixM(new string[3] { "flower", "flow", "flight" })
            .Should().Be("fl");

        Algorithms.LongestCommonPrefix.LongestCommonPrefixM(new string[3] { "dog", "racecar", "car" })
          .Should().Be("");
    }

    [Fact]
    public void LongestCommonPrefixM2_GivenMultiSet_ShouldReturnExpectedRes()
    {
        Algorithms.LongestCommonPrefix.LongestCommonPrefixM2(new string[3] { "flower", "flow", "flight" })
            .Should().Be("fl");

        Algorithms.LongestCommonPrefix.LongestCommonPrefixM2(new string[3] { "dog", "racecar", "car" })
          .Should().Be("");
    }
}
