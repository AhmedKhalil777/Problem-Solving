using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Tests;

public class Reverse_Words_in_a_String_III
{
    [Fact]
    public void ReverseWords()
    {
        Algorithms.Reverse_Words_in_a_String_III.ReverseWords("Let's take LeetCode contest")
            .Should().Be("s'teL ekat edoCteeL tsetnoc");

        Algorithms.Reverse_Words_in_a_String_III.ReverseWords("God Ding")
            .Should().Be("doG gniD");
    }
}
