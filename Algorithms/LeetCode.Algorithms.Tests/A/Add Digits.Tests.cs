using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Tests;

public class Add_Digits
{
    [Theory(DisplayName = "Given an integer num, repeatedly add all its digits until the result has only one digit, and return it.")]
    [InlineData(38,2)]
    [InlineData(0,0)]
    public void AddDigits(int num, int res)
    {
        new Algorithms.Add_Digits().AddDigits(num).Should().Be(res);
    }
}
