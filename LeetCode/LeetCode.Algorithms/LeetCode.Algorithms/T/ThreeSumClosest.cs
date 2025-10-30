using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms;

public class ThreeSumClosestClass
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        if (nums.Length < 3)
            return 0;

        Array.Sort(nums);
        int start = 0;
        int left = 1;
        int right = nums.Length - 1;
        int minDistance = int.MaxValue;
        int sum = int.MinValue;

        while (start < nums.Length - 2)
        {
            while (left < right)
            {
                int currSum = nums[start] + nums[left] + nums[right];
                if (currSum == target)
                    return target;

                if (currSum < target)
                    left++;
                else
                    right--;

                if (Math.Abs(currSum - target) < minDistance)
                {
                    sum = currSum;
                    minDistance = Math.Abs(currSum - target);
                }
            }
            start++;
            left = start + 1;
            right = nums.Length - 1;
        }
        return sum;
    }
}
