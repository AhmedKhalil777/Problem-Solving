namespace LeetCode.Algorithms;

public static class RunningSumof1dArray
{
    public static int[] RunningSum(int[] nums)
    {
        if (nums.Length == 0)
        {
            return nums;
        }
        var res = new int[nums.Length];
        res[0] = nums[0];
        var i = 0;
        while (++i < nums.Length)
        {
            res[i] = res[i-1] + nums[i];
        }
        return res;
    }
}
