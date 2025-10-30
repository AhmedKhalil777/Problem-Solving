namespace LeetCode.Algorithms.Tests;

public class RotateArray
{
    [Fact]
    public void Rotate()
    {

        Algorithms.RotateArray.Rotate(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3)
           .Should().Equal(new int[] { 5, 6, 7, 1, 2, 3, 4 });
        Algorithms.RotateArray.Rotate(new int[] { -1, -100, 3, 99 }, 2)
                .Should().Equal(new int[] { 3, 99, -1, -100 });
    }
}
