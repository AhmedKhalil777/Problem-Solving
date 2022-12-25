namespace LeetCode.Algorithms.Tests;

public class ZigzagConversion
{
    [Fact]
    public void Convert()
    {
        Algorithms.ZigzagConversion.Convert("PAYPALISHIRING", 3).Should().Be("PAHNAPLSIIGYIR");
        Algorithms.ZigzagConversion.Convert("PAYPALISHIRING", 4).Should().Be("PINALSIGYAHRPI");
        Algorithms.ZigzagConversion.Convert("A", 1).Should().Be("A");
    }
}
