namespace LeetCode.Algorithms.Tests;

[UsesVerify]
public  class Pascal_s_Triangle
{
    [Fact]
    public async Task Generate()
    {
       await Verify(Algorithms.Pascal_s_Triangle.Generate(5));
    }

    [Fact]
    public async Task Generate1()
    {
        await Verify(Algorithms.Pascal_s_Triangle.Generate(1));
    }
}
