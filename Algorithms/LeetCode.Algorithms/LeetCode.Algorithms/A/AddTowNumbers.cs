﻿using System.Numerics;
using System.Text;
using System.Text.Json;

namespace LeetCode.Algorithms;


//Definition for singly-linked list.
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

public class AddTowNumbers
{


    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var res = new ListNode();
        var stringBuilder = new StringBuilder();
        while (l1 != null)
        {
            stringBuilder.Append(l1.val);
            l1 = l1.next;
        }
        BigInteger firstNum = BigInteger.Parse(string.Join("",stringBuilder.ToString().Reverse()));
        stringBuilder.Clear();
        while (l2 != null)
        {
            stringBuilder.Append(l2.val);
            l2 = l2.next;
        }
        BigInteger lastNum = BigInteger.Parse(string.Join("", stringBuilder.ToString().Reverse()));
        var sum = (firstNum + lastNum).ToString().Reverse()
            .ToList();  
        var node = res;
        while (true)
        {
            node.val = int.Parse(sum.First().ToString());
            sum.RemoveAt(0);
            if (sum.Count == 0)
            {
                break;
            }
            node.next = new ListNode();
            node = node.next;
        }
        return res;
    }
}
