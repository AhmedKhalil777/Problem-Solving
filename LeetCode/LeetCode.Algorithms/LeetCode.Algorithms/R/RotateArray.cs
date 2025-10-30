using Microsoft.Scripting.Utils;

namespace LeetCode.Algorithms;

public static class RotateArray
{

    public static int[] Rotate(int[] nums, int k)
    {
        var l = new List<int>();
        k %= nums.Length;
        l.AddRange(nums[(nums.Length - k)..]);
        l.AddRange(nums[..(nums.Length - k)]);
        l.ToArray().CopyTo(nums, 0);
        return nums;
    }
}
