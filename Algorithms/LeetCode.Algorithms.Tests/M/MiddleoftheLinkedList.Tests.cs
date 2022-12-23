namespace LeetCode.Algorithms.Tests;

[UsesVerify]
public class MiddleoftheLinkedList
{
    [Fact]
    public async void MiddleNode()
    {
       await Verify(Algorithms.MiddleoftheLinkedList.MiddleNode(new ListNode(1, 2, 3, 4, 5)));

    }

    [Fact]
    public async void MiddleNode1()
    {
        await Verify(Algorithms.MiddleoftheLinkedList.MiddleNode(new ListNode(1, 2, 3, 4, 5,6 )));

    }
}
