using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Tests;

public class Intersection_of_Two_Arrays_II
{
    [Fact]
    public void Instersect()
    {
        Algorithms.Intersection_of_Two_Arrays_II.Intersect(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 })
            .Should().Equal(new int[] { 2, 2 });

        Algorithms.Intersection_of_Two_Arrays_II.Intersect(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 })
             .Should().Equal(new int[] { 4, 9 });

    }
}
