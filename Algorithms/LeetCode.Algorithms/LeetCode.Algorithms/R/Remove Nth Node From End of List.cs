namespace LeetCode.Algorithms;

public static class Remove_Nth_Node_From_End_of_List
{
    public static ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        if (head == null)
        {
            return null;   
        }
        var stack = new Stack<ListNode>();
        var index = head;
        while (index != null)
        {
            stack.Push(index);
            index = index.next;
        }
        ListNode tempNode  = null;
        for (int i = 0; i < n; i++)
        {
           tempNode = stack.Pop();
        }

        var isPoped = stack.TryPop(out var indexBeforeN);
        if (!isPoped) { return tempNode.next; }
        indexBeforeN.next = indexBeforeN.next.next;
        return head;
    }
}
