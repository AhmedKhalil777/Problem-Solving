namespace LeetCode.Algorithms.Tests;


[UsesVerify]
public class ReverseLinkedList
{
    [Fact]
    public async void ReverseList()
    {
       await Verify(Algorithms.ReverseLinkedList.ReverseList(new ListNode(1, 2, 3, 4, 5)));
    }
}
