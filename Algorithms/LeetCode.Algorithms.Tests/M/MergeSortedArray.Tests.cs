namespace LeetCode.Algorithms.Tests;

public class MergeSortedArray
{
    [Fact]
    public void Merge()
    {
        Algorithms.MergeSortedArray.Merge(new int[] {1, 2, 3, 0, 0, 0 }, 3,new int[] { 2, 5, 6 },3)
            .Should().Equal(new int[] { 1, 2, 2, 3, 5, 6 });
        Algorithms.MergeSortedArray.Merge(new int[] { 1}, 1, new int[] { }, 0)
             .Should().Equal(new int[] { 1 });
        Algorithms.MergeSortedArray.Merge(new int[] { 0 }, 0, new int[] {1 }, 1)
             .Should().Equal(new int[] { 1 });
    }
}
