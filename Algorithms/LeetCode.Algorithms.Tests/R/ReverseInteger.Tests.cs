using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Tests;

public class ReverseInteger
{
    [Fact]
    public void Reverse_GivenMultiSet_ShouldReturnExpectedReverse()
    {
        Algorithms.ReverseInteger.Reverse(1534236469).
            Should().Be(0);     
        Algorithms.ReverseInteger.Reverse(-2147483648).
            Should().Be(0);


    }
}
