namespace LeetCode.Algorithms.Tests;

public class RotateImage
{
    [Fact]
    public void RotateTests()
    {
        Algorithms.RotateImage.Rotate(new int[3][] { new int[3] { 1, 2, 3 }, new int[3] { 4, 5, 6 }, new int[3] { 7, 8, 9 } })
            .Should().BeEquivalentTo(new int[3][] { new int[3] { 7, 4, 1 }, new int[3] { 8, 5, 2 }, new int[3] { 9, 6, 3 } });

    }

}
