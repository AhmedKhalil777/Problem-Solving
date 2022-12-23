//Definition for singly-linked list.
using System.Text.Json;

namespace LeetCode.Algorithms;


public class ListNode : IEquatable<ListNode>
{
    public int val { get; set; }
    public ListNode next { get; set; }
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }

    public bool Equals(ListNode? other)
    {
        return JsonSerializer.Serialize(this) == JsonSerializer.Serialize(other);
    }
}
