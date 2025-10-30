namespace LeetCode.Algorithms;

public static class ReverseLinkedList
{
    public static ListNode ReverseList(ListNode? head)
    {
        if (head == null)
        {
            return null;
        }
        var newList = new ListNode();
        while (true)
        {
            newList.val = head.val;
            head = head.next;
            if (head == null )
            {
                return newList;
            }
            var shuffle = new ListNode();
            shuffle.next = newList;
            newList = shuffle;
        }
    }
}
