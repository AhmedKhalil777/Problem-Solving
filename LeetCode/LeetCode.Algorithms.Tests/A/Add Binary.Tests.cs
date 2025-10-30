namespace LeetCode.Algorithms.Tests;

public class Add_Binary
{
    [Theory]
    [InlineData("11", "1", "100" )]
    [InlineData("1010", "1011", "10101" )]
    [InlineData("1", "111", "1000" )]
    [InlineData("101111", "10", "110001")]
    public void AddBinary(string a, string b, string expected)
    {
        new Algorithms.Add_Binary().AddBinary(a, b).Should().Be(expected);
    }
}
