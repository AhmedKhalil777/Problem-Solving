using System.Runtime.Intrinsics.X86;

namespace LeetCode.Algorithms.Tests;


public class RectangleArea
{

    [Fact]
    public void ComputeArea_GivenMultiSet_ShouldReturnExpectedArea()
    {
        Algorithms.RectangleArea.ComputeArea(0, 0, 0, 0, -1, -1, 1, 1)
        .Should().Be(4);
        Algorithms.RectangleArea.ComputeArea(ax1: -3, ay1: 0, ax2: 3, ay2: 4, bx1: 0, by1: -1, bx2: 9, by2: 2)
            .Should().Be(45);
        Algorithms.RectangleArea.ComputeArea(ax1 : -2, ay1 : -2, ax2 : 2, ay2 : 2, bx1 : -2, by1 : -2, bx2 : 2, by2 : 2)
            .Should().Be(16);


    }
}
