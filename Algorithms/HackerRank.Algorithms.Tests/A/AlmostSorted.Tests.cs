namespace HackerRank.Algorithms.Tests;

public class AlmostSorted
{
    [Fact]
    public void almostSorted_GivenArrCanSwapped_ShouldBeYesSwap()
    {
        Algorithms.AlmostSorted.almostSorted(new List<int>{4,2});
        Algorithms.AlmostSorted.IsSorted.Should().Be("yes");
        Algorithms.AlmostSorted.Sorting.Should().Be("swap 1 2");
    }
    
    [Fact]
    public void almostSorted_GivenArrCanNotSwapped_ShouldBeNoSwap()
    {
        Algorithms.AlmostSorted.almostSorted(new List<int>{3,1,2});
        Algorithms.AlmostSorted.IsSorted.Should().Be("no");
        Algorithms.AlmostSorted.Sorting.Should().Be(null);
    }
    
    
    [Fact]
    public void almostSorted_GivenArrCanBeReversible_ShouldBeReversed()
    {
        Algorithms.AlmostSorted.almostSorted(new List<int>{1, 5,4, 3, 2, 6});
        Algorithms.AlmostSorted.IsSorted.Should().Be("yes");
        Algorithms.AlmostSorted.Sorting.Should().Be("reverse 2 5");
    }
    
    
    
}