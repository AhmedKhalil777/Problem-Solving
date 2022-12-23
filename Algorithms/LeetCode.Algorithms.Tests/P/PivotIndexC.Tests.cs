using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Tests;

public class PivotIndexC
{
    [Fact]
    public void PivotIndex()
    {
        Algorithms.PivotIndexC.PivotIndex(new int[] { 1, 7, 3, 6, 5, 6 }).Should().Be(3);
        Algorithms.PivotIndexC.PivotIndex(new int[] { 1, 2, 3 }).Should().Be(-1);
        Algorithms.PivotIndexC.PivotIndex(new int[] { 2, 1, -1 }).Should().Be(0);
        Algorithms.PivotIndexC.PivotIndex(new int[] { -1, -1, -1, -1, -1, 0 }).Should().Be(2);
    }
}
