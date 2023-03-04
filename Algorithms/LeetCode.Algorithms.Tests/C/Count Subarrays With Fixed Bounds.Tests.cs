namespace LeetCode.Algorithms.Tests;

public class Count_Subarrays_With_Fixed_Bounds
{
    [Theory]
    [InlineData(new int[] { 1, 3, 5, 2, 7, 5 }, 1, 5, 2)]
    [InlineData(new int[] { 1, 1, 1, 1 }, 1, 1, 10)]
    [InlineData(new int[] { 35054,398719,945315,945315,820417,945315,35054,945315,171832,945315,35054,109750,790964,441974,552913 }, 35054, 945315, 81)]
    public void CountSubarrays(int[] nums, int min, int max, long count)
    {
        new Algorithms.Count_Subarrays_With_Fixed_Bounds()
            .CountSubarraysII(nums, min, max)
            .Should()
            .Be(count);
    }
}