namespace LeetCode.Algorithms;

public static class LinkedListCycleII
{
    public static ListNode DetectCycle(ListNode? head)
    {
        ListNode slow = head;
        ListNode fast = head;

        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;

            if (fast == slow)
            {
                ListNode slow2 = head;
                while (slow2 != slow)
                {
                    slow = slow.next;
                    slow2 = slow2.next;
                }
                return slow;
            }
        }
        return null;
    }
}
