namespace LeetCode.Algorithms;

public class ContainsDuplicate
{

    public static bool ContainsNearbyAlmostDuplicate(int[] nums, int indexDiff, int valueDiff)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length && j - i <= indexDiff; j++)
            {
                if (Math.Abs(nums[i] - nums[j]) <= valueDiff)
                {
                    return true;
                }
            }
        }
        return false;
    }

    public static bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j  = i + 1; j  < nums.Length && j - i <= k; j ++)
            {
                if (nums[i] == nums[j] )
                {
                    return true;   
                }
            }
        }
        return false;
    }


    public static bool ContainsDuplicateI(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j])
                {
                    return true;
                }
            }
        }
        return false;
    }
}
