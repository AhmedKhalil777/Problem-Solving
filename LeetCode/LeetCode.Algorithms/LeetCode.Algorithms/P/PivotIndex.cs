namespace LeetCode.Algorithms;

public static class PivotIndexC
{
    public static int PivotIndex(int[] nums)
    {
        int pivot = -1;
        int n = nums.Length;
        if (nums == null || n == 0) return pivot;

        int left = 0, right = nums[0];
        for (int i = 1; i < n; i++)
        {
            right += nums[i];
        }

        for (int i = 0; i < n; i++)
        {
            right -= nums[i];
            if (left == right) return i;
            left += nums[i];
        }

        return pivot;
    }

}
