namespace LeetCode.Algorithms.Tests;

public class PermutationSequence
{
    [Fact]
    public void GetPermutationTests()
    {
        Algorithms.PermutationSequence.GetPermutation(3, 3).Should().Be("213");
        Algorithms.PermutationSequence.GetPermutation(4, 9).Should().Be("2314");
        Algorithms.PermutationSequence.GetPermutation(3, 1).Should().Be("123");
    }
}
