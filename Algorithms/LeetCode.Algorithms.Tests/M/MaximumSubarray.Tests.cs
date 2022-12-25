namespace LeetCode.Algorithms.Tests;

public class MaximumSubarray
{
    [Fact]
    public void MaxSubArray()
    {
        Algorithms.MaximumSubarray.MaxSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 })
            .Should().Be(6);
        Algorithms.MaximumSubarray.MaxSubArray(new int[] { 1 })
         .Should().Be(1);
        Algorithms.MaximumSubarray.MaxSubArray(new int[] { 5, 4, -1, 7, 8 })
            .Should().Be(23);
    }
}
