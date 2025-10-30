using Newtonsoft.Json;

namespace LeetCode.Algorithms.Tests;

public class Number_of_Islands
{
    [Theory]
    [InlineData("[\r\n  [\"1\",\"1\",\"1\",\"1\",\"0\"],\r\n  [\"1\",\"1\",\"0\",\"1\",\"0\"],\r\n  [\"1\",\"1\",\"0\",\"0\",\"0\"],\r\n  [\"0\",\"0\",\"0\",\"0\",\"0\"]\r\n]", 1)]
    [InlineData("[\r\n  [\"1\",\"1\",\"0\",\"0\",\"0\"],\r\n  [\"1\",\"1\",\"0\",\"0\",\"0\"],\r\n  [\"0\",\"0\",\"1\",\"0\",\"0\"],\r\n  [\"0\",\"0\",\"0\",\"1\",\"1\"]\r\n]", 3)]
    public void NumIslands(string actJson, int res)
    {
        var actual = JsonConvert.DeserializeObject<char[][]>(actJson);
        Algorithms.Number_of_Islands.NumIslands(actual).Should().Be(res);
    }
}
