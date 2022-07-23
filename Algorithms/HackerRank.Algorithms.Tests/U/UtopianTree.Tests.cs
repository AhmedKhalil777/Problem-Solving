namespace HackerRank.Algorithms.Tests;

public class UtopianTree
{
    [Fact]
    public void utopianTree_GivenNOfCycles_ShouldReturnTreeHeight()
    {
        Algorithms.UtopianTree.utopianTree(0).Should().Be(1);
        Algorithms.UtopianTree.utopianTree(1).Should().Be(2);
        Algorithms.UtopianTree.utopianTree(4).Should().Be(7);
    }
}