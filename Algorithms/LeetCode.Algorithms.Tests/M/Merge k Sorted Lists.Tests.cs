using System.Text.Json;

namespace LeetCode.Algorithms.Tests;

public class Merge_k_Sorted_Lists
{
    [Theory]
    [InlineData("[[1,4,5],[1,3,4],[2,6]]", "[1,1,2,3,4,4,5,6]")]
    [InlineData("[]", "[]")]
    public void MergeKLists(string json, string expectedJson)
    {
        var arr = JsonSerializer.Deserialize<int[][]>(json);
        var lists = arr.Select(x => new ListNode(x)).ToArray();
        var actual = new Algorithms.Merge_k_Sorted_Lists()?.MergeKLists(lists)?.ToArray() ?? Array.Empty<int>();
        JsonSerializer.Serialize(actual).Should().Be(expectedJson);

    }
    
}