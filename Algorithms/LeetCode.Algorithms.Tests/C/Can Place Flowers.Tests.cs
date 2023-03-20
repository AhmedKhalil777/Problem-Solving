using System.Text.Json;

namespace LeetCode.Algorithms.Tests;
public class Can_Place_Flowers
{
    [Theory]
    [InlineData("[1,0,0,0,1]", 1, true)]
    [InlineData("[1,0,0,0,1]", 2, false)]
    [InlineData("[1,0,0,0,0,1]", 2, false)]
    [InlineData("[0]", 1, true)]
    public void CanPlaceFlowers(string jsonInput, int n , bool res)
    {
        var input = JsonSerializer.Deserialize<int[]>(jsonInput);
        new Algorithms.Can_Place_Flowers().CanPlaceFlowers(input, n).Should().Be(res);
    }
}
