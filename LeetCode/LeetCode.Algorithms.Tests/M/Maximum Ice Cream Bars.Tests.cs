using Newtonsoft.Json;

namespace LeetCode.Algorithms.Tests;

public class Maximum_Ice_Cream_Bars
{
    [Theory]
    [InlineData("[1,3,2,4,1]",7, 4)]
    [InlineData("[1,3,2,4,1]", 5, 3)]
    [InlineData("[1,6,3,1,2,5]", 20, 6)]
    public void MaxIceCream(string actJson, int coins ,int res)
    {
        var actualCosts = JsonConvert.DeserializeObject<int[]>(actJson);
        Algorithms.Maximum_Ice_Cream_Bars.MaxIceCream(actualCosts, coins)
            .Should().Be(res);
        Algorithms.Maximum_Ice_Cream_Bars.MaxIceCreamM1(actualCosts, coins)
            .Should().Be(res);
    }
}
