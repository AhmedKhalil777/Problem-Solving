namespace LeetCode.Algorithms.Tests;

public class TowSumII
{
    [Fact]
    public void TowSum()
    {
        Algorithms.Two_Sum_II.TwoSum(new int[] { 2, 7, 11, 15 }, 9)
            .Should().Equal(new int[] { 1, 2 });
        Algorithms.Two_Sum_II.TwoSum(new int[] { 2, 3, 4 }, 6)
            .Should().Equal(new int[] { 1, 3 });
        Algorithms.Two_Sum_II.TwoSum(new int[] { -1, 0 }, -1)
            .Should().Equal(new int[] { 1, 2 });
    }
}
