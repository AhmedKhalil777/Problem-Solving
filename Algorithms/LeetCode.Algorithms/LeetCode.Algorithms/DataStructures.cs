//Definition for singly-linked list.
using System.Data.SqlTypes;
using System.Text.Json;

namespace LeetCode.Algorithms;


public class ListNode : IEquatable<ListNode>, INullable
{
    public int val { get; set; }
    public ListNode? next { get; set; }

    public bool IsNull => this is null;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }

    public ListNode(params int[] list)
    {
        if (!list.Any())
        {
            return;
        }
        var tmb = this;
        for (int i = 0; i < list.Length; i++)
        {
            tmb.val = list[i];
            if (!(i == (list.Length - 1)))
            {
                tmb.next = new ListNode();
                tmb = tmb.next;
            }
        }

    }

    public int[] ToArray()
    {
        var res = new List<int> { this.val };
        var cur = this;
        
        while (cur.next != null)
        {
            cur = cur.next;
            res.Add(cur.val);
        }

        return res.ToArray();
    }

    public void AddToLast(ListNode node)
    {
        var last = this;
        while (last.next is not null)
        {
            last = last.next;
        }
        last.next = node;
    }

    public bool Equals(ListNode? other)
    {
        return JsonSerializer.Serialize(this) == JsonSerializer.Serialize(other);
    }
}


public class Node
{
    public int val;
    public IList<Node> children;

    public Node() { }

    public Node(int _val)
    {
        val = _val;
    }

    public Node(int _val, IList<Node> _children)
    {
        val = _val;
        children = _children;
    }
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}