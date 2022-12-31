
using Newtonsoft.Json;

namespace LeetCode.Algorithms.Tests;

[UsesVerify]
public class Flood_Fill
{
    [Theory]
    [InlineData("[[1,1,1],[1,1,0],[1,0,1]]", 1,1,2,"ExampleI")]
    [InlineData("[[0,0,0],[0,0,0]]", 0,0,0,"Example2")]
    public async Task FloodFill(string imageJsonAct ,int sr, int sc, int color, string testVerificationName)
    {
        var actual = JsonConvert.DeserializeObject<int[][]>(imageJsonAct);
        await Verify(Algorithms.Flood_Fill.FloodFill(actual, sr, sc, color))
            .UseTextForParameters(testVerificationName);
    }
}
