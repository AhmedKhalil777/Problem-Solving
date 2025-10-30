namespace LeetCode.Algorithms;

public static class MaximumSubarray
{
    /// <summary>
    /// Kadane algorithm
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public static int MaxSubArray(int[] nums)
    {
        int size = nums.Length;
        int max_so_far = int.MinValue, max_ending_here = 0;

        for (int i = 0; i < size; i++)
        {
            max_ending_here +=  nums[i];

            if (max_so_far < max_ending_here)
                max_so_far = max_ending_here;

            if (max_ending_here < 0)
                max_ending_here = 0;
        }

        return max_so_far;
    }
}
