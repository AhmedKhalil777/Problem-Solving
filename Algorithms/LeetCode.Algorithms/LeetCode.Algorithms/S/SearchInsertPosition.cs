using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms;

public static class SearchInsertPosition
{
    public static int SearchInsert(int[] nums, int target)
    {
        var l = nums.ToList();
        l.Add(int.MaxValue);
        nums = l.ToArray();

        int minNum = 0;
        int maxNum = nums.Length - 1;
        int mid = 0;

        while (minNum <= maxNum)
        {
            mid = (minNum + maxNum) / 2;
            if (target >= nums[mid] && target < nums[mid+1])
            {
                if (target == nums[mid])
                {
                    return mid;
                }
                return mid +1;
            }
            else if (target < nums[mid])
            {
                maxNum = mid - 1;
            }
            else
            {
                minNum = mid + 1;
            }
        }

        return mid ;
    }
}
