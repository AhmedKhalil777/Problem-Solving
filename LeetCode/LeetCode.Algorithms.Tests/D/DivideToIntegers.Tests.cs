namespace LeetCode.Algorithms.Tests;

public class DivideToIntegers
{

    [Fact]
    public void DivideTest()
    {
        Algorithms.DivideToIntegers.Divide(-2147483648, -1)
            .Should().Be(int.MaxValue);
    }
}
