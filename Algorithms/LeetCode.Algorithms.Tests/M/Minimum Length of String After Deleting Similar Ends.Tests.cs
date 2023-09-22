using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Tests;

public class Minimum_Length_of_String_After_Deleting_Similar_Ends
{
    [Theory(DisplayName = "Minimum Length should return Minimum Length of String After Deleting Similar Ends")]
    [InlineData("ca",2)]
    [InlineData("cabaabac", 0)]
    [InlineData("aabccabba", 3)]
    [InlineData("bbbbbbbbbbbbbbbbbbbbbbbbbbbabbbbbbbbbbbbbbbccbcbcbccbbabbb", 1)]
    [InlineData("bbbbbbbbbbbbbbbbbbb", 0)]

    public void MinimumLength(string s, int res)
    {
        new Algorithms.Minimum_Length_of_String_After_Deleting_Similar_Ends().MinimumLength(s).Should().Be(res);
    }
}
