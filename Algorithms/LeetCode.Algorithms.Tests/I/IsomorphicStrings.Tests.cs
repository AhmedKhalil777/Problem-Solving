using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Tests;

public class IsomorphicStrings
{
    [Fact]
    public void IsIsomorphic()
    {
        Algorithms.IsomorphicStrings.IsIsomorphic(s: "egg", t: "add").Should().BeTrue();
        Algorithms.IsomorphicStrings.IsIsomorphic(s: "foo", t: "bar").Should().BeFalse();
        Algorithms.IsomorphicStrings.IsIsomorphic(s: "paper", t: "title").Should().BeTrue();
        Algorithms.IsomorphicStrings.IsIsomorphic(s: "badc", t: "baba").Should().BeFalse();
    }
}
