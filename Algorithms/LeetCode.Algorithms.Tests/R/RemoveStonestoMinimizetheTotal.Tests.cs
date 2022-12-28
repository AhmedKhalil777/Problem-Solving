using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Tests;

public class RemoveStonestoMinimizetheTotal
{
    [Fact]
    public void MinStoneSum()
    {
        Algorithms.RemoveStonestoMinimizetheTotal.MinStoneSum(new int[] { 5, 4, 9 }, 2).Should().Be(12);
        Algorithms.RemoveStonestoMinimizetheTotal.MinStoneSum(new int[] { 4, 3, 6, 7 }, 3).Should().Be(12);
        Algorithms.RemoveStonestoMinimizetheTotal.MinStoneSum(new int[] { 4122, 9928, 3477, 9942 }, 6).Should().Be(8768);
    }

}
