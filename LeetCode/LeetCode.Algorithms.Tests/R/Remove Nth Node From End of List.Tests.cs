namespace LeetCode.Algorithms.Tests;

[UsesVerify]
public class Remove_Nth_Node_From_End_of_List
{
    [Fact]
    public async Task RemoveNthFromEnd()
    {
        var node = new ListNode(new int[] { 1, 2, 3, 4, 5});
        await Verify(Algorithms.Remove_Nth_Node_From_End_of_List.RemoveNthFromEnd(node, 2));
    }

    [Fact]
    public  void RemoveNthFromEnd_Nulls()
    {
        var node = new ListNode(new int[] { 1});
        Algorithms.Remove_Nth_Node_From_End_of_List.RemoveNthFromEnd(node, 1).Should().BeNull();
    }


    [Fact]
    public async Task RemoveNthFromEndI()
    {
        var node2 = new ListNode(new int[] { 1, 2 });
        await Verify(Algorithms.Remove_Nth_Node_From_End_of_List.RemoveNthFromEnd(node2, 2));
    }


    [Fact]
    public async Task RemoveNthFromEndII()
    {
        var node = new ListNode(new int[] { 1,2 });
        await Verify(Algorithms.Remove_Nth_Node_From_End_of_List.RemoveNthFromEnd(node, 1));
    }
}
