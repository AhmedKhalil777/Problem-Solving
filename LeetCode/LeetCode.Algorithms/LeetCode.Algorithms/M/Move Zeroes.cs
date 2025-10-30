using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms;

public static class Move_Zeroes
{
    public static void MoveZeroes(int[] nums)
    {
        int j = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[j++] = nums[i];
            }
        }
        for (; j < nums.Length; j++)
        {
            nums[j] = 0;
        }
    }


    public static void MoveZeroes1(int[] nums)
    {
        var zeroezCount = nums.Count(x => x == 0);
        var res = nums.ToList();
        res.RemoveAll(x => x == 0);
        res.AddRange(Enumerable.Repeat(0, zeroezCount));
        res.ToArray().CopyTo(nums, 0);
    }
}
