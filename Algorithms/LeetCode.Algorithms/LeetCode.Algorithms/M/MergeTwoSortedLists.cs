using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LeetCode.Algorithms.AddTowNumbers;

namespace LeetCode.Algorithms;

public static class MergeTwoSortedLists
{
    public static ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        if (list1 == null && list2 == null)
        {
            return null;
        }
        ListNode res = new ListNode();
        var index = res;
        bool firstTime = true;
        while (true)
        {

            if (list1 != null && list2 != null && list1.val == list2.val)
            {
                if (!firstTime)
                {
                    index.next = new ListNode();
                    index = index.next;
                }
                index.val = list1.val;
                index.next = new ListNode();
                list1 = list1.next;
                index = index.next;
                index.val = list2.val;
                list2 = list2.next;
            }
            else if (list1 != null && list2 != null &&  list1.val < list2.val)
            {
                if (!firstTime)
                {
                    index.next = new ListNode();
                    index = index.next;
                }
                index.val = list1.val;
                list1 = list1.next;
            }
            else if(list1 != null && list2 != null)
            {
                if (!firstTime)
                {
                    index.next = new ListNode();
                    index = index.next;
                }
                index.val = list2.val;
                list2 = list2.next;
            }
            else if (list1 != null && list2 == null)
            {
                if (!firstTime)
                {
                    index.next = new ListNode();
                    index = index.next;
                }
                index.val =   list1.val;
                index.next = list1.next;
                list1 = null;
            }
            else if (list1 == null && list2 != null)
            {
                if (!firstTime)
                {
                    index.next = new ListNode();
                    index = index.next;
                }
                index.val = list2.val;
                index.next = list2.next;
                list2 = null;
            }
            else
            {
                break;
            }


            firstTime = false;
        }
        return res;
    }

    public static ListNode? MergeTwoListsSecond(ListNode? list1, ListNode? list2)
    {
        ListNode? head = new ListNode(0, null);
        ListNode? head1 = list1;
        ListNode? head2 = list2;
        ListNode? headTemp = head;
        while (head1 != null && head2 != null)
        {
            if (head1.val <= head2.val)
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                headTemp.next = head1;

                head1 = head1.next;
            }
            else if (head1.val > head2.val)
            {
                headTemp.next = head2;
                head2 = head2.next;
            }
            headTemp = headTemp.next;
        }
        if (head1 != null) headTemp.next = head1;
        if (head2 != null) headTemp.next = head2;
        return head.next;
#pragma warning restore CS8602 // Dereference of a possibly null reference.
    }
}
