namespace LeetCode.Algorithms.Tests;

public class Validate_Binary_Search_Tree
{
    [Fact]
    public void IsValidBST1()
    {
        var node = new TreeNode(2, 
            new TreeNode(1),
            new TreeNode (3));
        Algorithms.Validate_Binary_Search_Tree.IsValidBST(node).Should().BeTrue();
    }

    [Fact]
    public void IsValidBST2()
    {
        var node = new TreeNode(5,
            new (1),
            new (4, new (3), new(6)));
        Algorithms.Validate_Binary_Search_Tree.IsValidBST(node).Should().BeFalse();
    }

    [Fact]
    public void IsValidBST3()
    {
        var node = new TreeNode(2,
            new(2),
            new(2));
        Algorithms.Validate_Binary_Search_Tree.IsValidBST(node).Should().BeFalse();
    }
}
