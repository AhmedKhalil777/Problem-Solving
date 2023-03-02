namespace LeetCode.Algorithms.Tests;

public class String_Compression
{

    [Theory]
    [InlineData(new char[] {'a','a','b','b','c','c','c'}, 6)]
    [InlineData(new char[] {'a'}, 1)]
    [InlineData(new char[] {'a','b','b','b','b','b','b','b','b','b','b','b','b'}, 4)]
    public void Compress(char[] chars, int count)
    {
        var stringCompression = new Algorithms.String_Compression();
        stringCompression.Compress(chars).Should().Be(count);
    }
}