using System.Drawing;

namespace LeetCode.Algorithms;

public class Merge_k_Sorted_Lists
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        if (!lists.Any())
        {
            return null;
        }
        var pQ = new PriorityQueue<int, int>();
        foreach (var node in lists)
        {
            if (node == null) continue;
            var curr = node;
            while (curr.next != null)
            {
                pQ.Enqueue(curr.val, curr.val);
                curr = curr.next;
            }
            pQ.Enqueue(curr.val, curr.val);
        }

        if (!pQ.TryPeek(out _, out _))
        {
            return null;
        }
        var res = new ListNode();
        var resCur = res;
        while (pQ.TryDequeue(out var e, out _))
        {
            resCur.val = e;
            if (!pQ.TryPeek(out _, out _)) continue;
            resCur.next = new ();
            resCur = resCur.next;
        }

        return res;
    }
}