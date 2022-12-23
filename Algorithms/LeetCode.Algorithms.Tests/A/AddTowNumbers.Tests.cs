using static LeetCode.Algorithms.AddTowNumbers;

namespace LeetCode.Algorithms.Tests;

using System.Text.Json;

using ListNode = Algorithms.ListNode;
public class AddTowNumbers
{
    [Fact]
    public void AddTwoNumbers_GivenMultiSet_ShouldReturnExpectedRes()
    {
        var l1 = new ListNode(2, new(4, new(3)));
        var l2 = new ListNode(5, new(6, new(4)));
        var expected = new ListNode(7, new(0, new(8)));
        var res = JsonSerializer.Serialize(Algorithms.AddTowNumbers.AddTwoNumbers(l1, l2));
        res.Should().Be(JsonSerializer.Serialize(expected));
    }


    [Fact]
    public void AddTwoNumbers_GivenSet2_ShouldReturnExpectedRes()
    {
        var l1 = new ListNode(2, new(4, new(9)));
        var l2 = new ListNode(5, new(6, new(4, new (9))));
        var expected = new ListNode(7, new(0, new(4, new(0, new(1)))));
        var res = JsonSerializer.Serialize(Algorithms.AddTowNumbers.AddTwoNumbers(l1, l2));
        res.Should().Be(JsonSerializer.Serialize(expected));
    }
}
