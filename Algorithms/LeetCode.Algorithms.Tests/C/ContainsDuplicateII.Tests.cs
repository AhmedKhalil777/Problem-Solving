namespace LeetCode.Algorithms.Tests;

public class ContainsDuplicateII
{
    [Fact]
    public void ContainsNearbyDuplicate_GivenMultiSet_ShouldReturnExpectedRes()
    {
        Algorithms.ContainsDuplicateII.ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1 }, 3)
            .Should().BeTrue();
        Algorithms.ContainsDuplicateII.ContainsNearbyDuplicate(new int[] { 1, 0, 1, 1 }, 1)
         .Should().BeTrue();
        Algorithms.ContainsDuplicateII.ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1, 2, 3 }, 2)
          .Should().BeFalse();
        Algorithms.ContainsDuplicateII.ContainsNearbyDuplicate(new int[] { 99,99 }, 2)
            .Should().BeTrue();
    }
}
