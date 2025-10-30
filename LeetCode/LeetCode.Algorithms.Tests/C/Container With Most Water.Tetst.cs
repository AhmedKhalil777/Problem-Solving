using System.Text.Json;

namespace LeetCode.Algorithms.Tests;

public class Container_With_Most_Water
{
    [Theory]
    [InlineData("[1,1]", 1)]
    [InlineData("[1,8,6,2,5,4,8,3,7]", 49)]
    public void MaxArea(string json, int res)
    {
        var arr = JsonSerializer.Deserialize<int[]>(json);
        new Algorithms.Container_With_Most_Water().MaxArea(arr).Should().Be(res);
    }
}