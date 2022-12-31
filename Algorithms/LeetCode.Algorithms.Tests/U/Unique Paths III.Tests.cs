using Newtonsoft.Json;

namespace LeetCode.Algorithms.Tests;

public class Unique_Paths_III
{
    [Theory]
    [InlineData("[[1,0,0,0],[0,0,0,0],[0,0,2,-1]]", 2)]
    [InlineData("[[1,0,0,0],[0,0,0,0],[0,0,0,2]]", 4)]
    [InlineData("[[0,1],[2,0]]", 0)]
    public void UniquePathsIII(string jsonActual, int res)
    {
        var actual = JsonConvert.DeserializeObject<int[][]>(jsonActual);
        Algorithms.Unique_Paths_III.UniquePathsIII(actual).Should().Be(res);
    }
}
