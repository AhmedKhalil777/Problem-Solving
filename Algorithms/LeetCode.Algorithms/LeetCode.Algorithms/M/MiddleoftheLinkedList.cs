namespace LeetCode.Algorithms;

public static class MiddleoftheLinkedList
{
    public static ListNode MiddleNode(ListNode head)
    {
        if (head == null)
        {
            return null;
        }
        var length = 0;
        var tmb = head;
        while (tmb.next != null)
        {
            length++; 
            tmb= tmb.next;
        }
        tmb = head;
        length = (length +1) / 2;
        for (int i = 0; i < length; i++)
        {
            tmb = tmb.next;
        }
        return tmb;
    }
}
