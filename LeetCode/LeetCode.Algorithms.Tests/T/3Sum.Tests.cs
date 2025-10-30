
using System.Text.Json;

namespace LeetCode.Algorithms.Tests;

public class _3Sum
{
    [Theory]
    [InlineData("[-1,0,1,2,-1,-4]", "[[2,-1,-1],[1,0,-1]]")]
    [InlineData("[0,1,1]", "[]")]
    [InlineData("[0,0,0]", "[[0,0,0]]")]
    public void ThreeSum(string numsArrayJson, string expectedResJson)
    {
        var arr = JsonSerializer.Deserialize<int[]>(numsArrayJson);
        var res = new Algorithms._3Sum().ThreeSum(arr);
        var actResJson = JsonSerializer.Serialize(res);
        actResJson.Should().Be(expectedResJson);
    }
}
