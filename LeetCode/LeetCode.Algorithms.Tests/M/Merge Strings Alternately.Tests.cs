using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Tests;

public class Merge_Strings_Alternately
{
    [Theory]
    [InlineData("abc", "pqr", "apbqcr")]
    [InlineData("ab", "pqrs", "apbqrs")]
    public void MergeAlternately(string word1, string word2, string res)
    {
        new Algorithms.Merge_Strings_Alternately().MergeAlternately(word1, word2).Should().Be(res);
    }
}
