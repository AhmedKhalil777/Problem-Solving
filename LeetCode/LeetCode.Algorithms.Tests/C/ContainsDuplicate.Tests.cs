namespace LeetCode.Algorithms.Tests;

public class ContainsDuplicate
{


    [Fact]
    public void ContainsNearbyAlmostDuplicate_GivenMultiSet_ShouldReturnExpectedRes()
    {
        Algorithms.ContainsDuplicate.ContainsNearbyAlmostDuplicate(new int[] { 1, 2, 3, 1 }, 3, 0)
            .Should().BeTrue();
        Algorithms.ContainsDuplicate.ContainsNearbyAlmostDuplicate(new int[] { 1, 5, 9, 1, 5, 9 },2,3)
         .Should().BeFalse();
    }

    [Fact]
    public void ContainsNearbyDuplicate_GivenMultiSet_ShouldReturnExpectedRes()
    {
        Algorithms.ContainsDuplicate.ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1 }, 3)
            .Should().BeTrue();
        Algorithms.ContainsDuplicate.ContainsNearbyDuplicate(new int[] { 1, 0, 1, 1 }, 1)
         .Should().BeTrue();
        Algorithms.ContainsDuplicate.ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1, 2, 3 }, 2)
          .Should().BeFalse();
        Algorithms.ContainsDuplicate.ContainsNearbyDuplicate(new int[] { 99,99 }, 2)
            .Should().BeTrue();
    }

    [Fact]
    public void ContainsDuplicate_GivenMultiSet_ShouldReturnExpectedRes()
    {
        Algorithms.ContainsDuplicate.ContainsDuplicateI(new int[] { 1, 2, 3, 1 })
            .Should().BeTrue();
        Algorithms.ContainsDuplicate.ContainsDuplicateI(new int[] { 1, 0, 1, 1 })
         .Should().BeTrue();
        Algorithms.ContainsDuplicate.ContainsDuplicateI(new int[] { 1, 2, 3, 1, 2, 3 })
          .Should().BeTrue();
    }
}
