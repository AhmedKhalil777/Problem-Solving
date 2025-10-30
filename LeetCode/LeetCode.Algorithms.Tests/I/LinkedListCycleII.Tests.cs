using System.Collections.Generic;

namespace LeetCode.Algorithms.Tests;

public class LinkedListCycleII
{
    [Fact]
    public void DetectCycle()
    {
        var lList1 = new ListNode(new int[]{3, 2, 0, -4});
        lList1.AddToLast(lList1.next);
        Algorithms.LinkedListCycleII.DetectCycle(lList1).Should()
            .Match<ListNode>(x=> x.val == 2);

         lList1 = new ListNode(new int[] { 1,2 });
         lList1.AddToLast(lList1);
        Algorithms.LinkedListCycleII.DetectCycle(lList1).Should()
            .Match<ListNode>(x => x.val == 1);

        lList1 = new ListNode(new int[] { -1, -7, 7, -4, 19, 6, -9, -5, -2, -5 });
        lList1.AddToLast(lList1.next.next.next.next.next);
        Algorithms.LinkedListCycleII.DetectCycle(lList1).Should()
            .Match<ListNode>(x => x.val == 6);

    }
}
