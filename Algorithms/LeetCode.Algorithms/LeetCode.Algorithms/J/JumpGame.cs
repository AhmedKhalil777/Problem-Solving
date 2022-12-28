using IronPython.Compiler.Ast;

namespace LeetCode.Algorithms;

public static class JumpGame
{
    public static bool CanJump(int[] nums)
    {
        if (nums[0] == 0 && nums.Length == 1)
        {
            return true;
        }
        var res = MinJumps(nums, nums.Length);
        if (res != int.MaxValue)
        {
            return true;
        }
        return false;
    }


    // Returns Minimum number
    // of jumps to reach end
    public static int MinJumps(int[] arr, int n)
    {
        // jumps[0] will
        // hold the result
        int[] jumps = new int[n];
        int min;

        // Minimum number of jumps needed to
        // reach last element from last elements
        // itself is always 0
        jumps[n - 1] = 0;

        // Start from the second element, move
        // from right to left and construct the
        // jumps[] array where jumps[i] represents
        // minimum number of jumps needed to reach
        // arr[m-1] from arr[i]
        for (int i = n - 2; i >= 0; i--)
        {
            // If arr[i] is 0 then arr[n-1]
            // can't be reached from here
            if (arr[i] == 0)
            {
                jumps[i] = int.MaxValue;
            }

            // If we can directly reach to the end
            // point from here then jumps[i] is 1
            else if (arr[i] >= n - i - 1)
            {
                jumps[i] = 1;
            }

            // Otherwise, to find out the minimum
            // number of jumps needed to reach
            // arr[n-1], check all the points
            // reachable from here and jumps[] value
            // for those points
            else
            {
                // initialize min value
                min = int.MaxValue;

                // following loop checks with all
                // reachable points and takes the minimum
                for (int j = i + 1;
                     j < n && j <= arr[i] + i; j++)
                {
                    if (min > jumps[j])
                    {
                        min = jumps[j];
                    }
                }

                // Handle overflow
                if (min != int.MaxValue)
                {
                    jumps[i] = min + 1;
                }
                else
                {
                    jumps[i] = min; // or Integer.MAX_VALUE
                }
            }
        }

        return jumps[0];
    }

}
