namespace HackerRank.Algorithms.Tests;

public class PickingNumbers
{
    [Fact]
    public void pickingNumbers_GivenListOfNums_ShouldReturnLongestStreakOfAbsoluteOnes()
    {
        Algorithms.PickingNumbers.pickingNumbers(new List<int>{4, 6, 5, 3, 3, 1}).Should().Be(3);
        Algorithms.PickingNumbers.pickingNumbers(new List<int>{1, 2 ,2, 3 ,1, 2}).Should().Be(5);
        Algorithms.PickingNumbers.pickingNumbers(new List<int>{98 ,3, 99, 1, 97, 2}).Should().Be(2);
    }

    [Fact]
    public void pickingNumbers_GivenFileListOfNums_ShouldReturnLongestStreakOfAbsoluteOnes()
    {
        Algorithms.PickingNumbers.pickingNumbers("./P/numbersTest.txt".AsFileIntList()).Should().Be(3);
    }
}