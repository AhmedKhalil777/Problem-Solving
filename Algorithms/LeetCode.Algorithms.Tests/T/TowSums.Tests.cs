namespace LeetCode.Algorithms.Tests;

public class TowSums
{
    [Fact]
    public void TowSums_GivenMultiSet_ShouldReturnExpectedRes()
    {
        Algorithms.TowSum.TwoSum(new int[] { 3, 2, 4 }, 6)
            .Should().Equal(1,2);
    }

}
