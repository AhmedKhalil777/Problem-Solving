namespace LeetCode.Algorithms;

public class ContainsDuplicateII
{
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
}
