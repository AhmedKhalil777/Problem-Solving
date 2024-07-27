using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Tests;

public class ThreeSumClosestClass
{
    [Theory]
    [InlineData("[-1,2,1,-4]", 1,2)]
    [InlineData("[0,0,0]", 1,0)]
    public void ThreeSumClosest(string numsArrayJson, int target ,int expected)
    {
        var arr = JsonSerializer.Deserialize<int[]>(numsArrayJson);
        new Algorithms.ThreeSumClosestClass().ThreeSumClosest(arr, target).Should().Be(expected);
    }
}
