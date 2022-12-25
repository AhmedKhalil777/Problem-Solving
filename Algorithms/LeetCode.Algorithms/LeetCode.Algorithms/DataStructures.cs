//Definition for singly-linked list.
using System.Data.SqlTypes;
using System.Text.Json;

namespace LeetCode.Algorithms;


public class ListNode : IEquatable<ListNode>, INullable
{
    public int val { get; set; }
    public ListNode? next { get; set; }

    public bool IsNull =>  this is null;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }

    public ListNode(params int[] list)
    {
        var tmb = this;
        for (int i = 0; i < list.Length; i++)
        {
            tmb.val = list[i];
            if (!(i == (list.Length -1)) )
            {
                tmb.next = new ListNode();
                tmb = tmb.next;
            }
        }

    }

    public bool Equals(ListNode? other)
    {
        return JsonSerializer.Serialize(this) == JsonSerializer.Serialize(other);
    }
}
