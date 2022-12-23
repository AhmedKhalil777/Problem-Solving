namespace LeetCode.Algorithms.Tests;

[UsesVerify]
public class MergeTwoSortedLists
{
    [Fact]
    public async void MergeTwoLists()
    {
        var actual = Algorithms.MergeTwoSortedLists.MergeTwoLists(new(1), null);
        await Verify(actual);

    }

    [Fact]
    public async void MergeTwoLists2()
    {
        var actual = Algorithms.MergeTwoSortedLists.MergeTwoLists(new Algorithms.ListNode(1, new ListNode(2, new ListNode(4))),
            new Algorithms.ListNode(1, new ListNode(3, new ListNode(4))));
        await Verify(actual);

    }

    [Fact]
    public async void MergeTwoListsSecond()
    {
        var actual = Algorithms.MergeTwoSortedLists.MergeTwoListsSecond(new(1), null);
        await Verify(actual);

    }

    [Fact]
    public async void MergeTwoListsSecond2()
    {
        var actual = Algorithms.MergeTwoSortedLists.MergeTwoListsSecond(new Algorithms.ListNode(1, new ListNode(2, new ListNode(4))),
            new Algorithms.ListNode(1, new ListNode(3, new ListNode(4))));
        await Verify(actual);

    }
}
