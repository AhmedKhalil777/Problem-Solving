namespace LeetCode.Algorithms.Tests;

public class MedianOf2SortedArrays
{
    [Fact]
    public void FindMedianSortedArrays_GivenMultiSet_ShouldReturnExpectedRes()
    {
        Algorithms.MedianOf2SortedArrays.FindMedianSortedArrays(new int[] { 1, 3 }, new int[] { 2 })
            .Should().Be(2);
        Algorithms.MedianOf2SortedArrays.FindMedianSortedArrays(new int[] { 1, 2 }, new int[] {3, 4 })
         .Should().Be(2.5);
    }

}
