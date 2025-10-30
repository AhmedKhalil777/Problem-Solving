namespace LeetCode.Algorithms.Tests;

public class SearchInsertPosition
{
    [Fact]
    public void SearchInsert()
    {
        Algorithms.SearchInsertPosition.SearchInsert(new int[] { 1, 3, 5, 6 }, 5)
            .Should().Be(2);
        Algorithms.SearchInsertPosition.SearchInsert(new int[] { 1, 3, 5, 6 }, 2)
         .Should().Be(1);
        Algorithms.SearchInsertPosition.SearchInsert(new int[] { 1, 3, 5, 6 }, 7)
          .Should().Be(4);
        Algorithms.SearchInsertPosition.SearchInsert(new int[] { 1, 3, 5, 6 }, 0)
            .Should().Be(0);
        Algorithms.SearchInsertPosition.SearchInsert(new int[] { 1 }, 1)
         .Should().Be(0);
    }
}
    