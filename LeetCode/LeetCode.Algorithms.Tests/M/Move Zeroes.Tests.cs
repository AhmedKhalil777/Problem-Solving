namespace LeetCode.Algorithms.Tests;

public class Move_Zeroes
{
    [Fact]
    public void MoveZeroes()
    {
        var actual1 = new int[] { 0, 1, 0, 3, 12 };
        var expected1 = new int[] { 1, 3, 12, 0, 0 };
        Algorithms.Move_Zeroes.MoveZeroes(actual1);
        actual1.Should().Equal(expected1);
        //////////////////////
        var actual2 = new int[] { 0 };
        var expected2 = new int[] { 0 };
        Algorithms.Move_Zeroes.MoveZeroes(actual2);
        actual2.Should().Equal(expected2);
    }
}
