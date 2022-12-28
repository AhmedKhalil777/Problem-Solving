using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms;

public static class Intersection_of_Two_Arrays_II
{
    public static int[] Intersect(int[] nums1, int[] nums2)
    {
        var longest = nums1.Length >= nums2.Length ? nums1.ToList() : nums2.ToList();
        var shortest = nums1.Length < nums2.Length ? nums1.ToList() : nums2.ToList();
        var res = new List<int>();
        for (int i = 0; i < shortest.Count; i++)
        {
            if (longest.Any(x=> x == shortest[i]))
            {
                res.Add(shortest[i]);
                longest.Remove(shortest[i]);
            }
        }
        return res.ToArray();
    }
}
