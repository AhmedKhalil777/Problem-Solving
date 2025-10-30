using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Tests;

public class ValidParentheses
{

    [Fact]
    public void ValidParenthesesTests()
    {
        Algorithms.ValidParentheses.IsValid("{}").Should().BeTrue();
        Algorithms.ValidParentheses.IsValid("{").Should().BeFalse();
        Algorithms.ValidParentheses.IsValid("{()}").Should().BeTrue();
        Algorithms.ValidParentheses.IsValid("()[]{}").Should().BeTrue();
        Algorithms.ValidParentheses.IsValid("(([]){})").Should().BeTrue();
        Algorithms.ValidParentheses.IsValid("[({(())}[()])]").Should().BeTrue();
        Algorithms.ValidParentheses.IsValid("){").Should().BeFalse();

    }

    [Fact]
    public void ValidParenthesesTests2()
    {
        Algorithms.ValidParentheses.IsValid2("{}").Should().BeTrue();
        Algorithms.ValidParentheses.IsValid2("{").Should().BeFalse();
        Algorithms.ValidParentheses.IsValid2("{()}").Should().BeTrue();
        Algorithms.ValidParentheses.IsValid2("()[]{}").Should().BeTrue();
        Algorithms.ValidParentheses.IsValid2("(([]){})").Should().BeTrue();
        Algorithms.ValidParentheses.IsValid2("[({(())}[()])]").Should().BeTrue();
        Algorithms.ValidParentheses.IsValid2("){").Should().BeFalse();

    }
}
