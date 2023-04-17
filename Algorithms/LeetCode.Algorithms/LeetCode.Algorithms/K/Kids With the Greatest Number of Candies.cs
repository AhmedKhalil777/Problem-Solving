using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms;

public class Kids_With_the_Greatest_Number_of_Candies
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var maxAdjusted = candies.Max() - extraCandies;
        return candies.Select(_ => _  >= maxAdjusted).ToList();
    }
}
