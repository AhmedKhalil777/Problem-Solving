namespace LeetCode.Algorithms;

public class _3Sum
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();

        if (nums.Length < 3)
        {
            return result;
        }

        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++)
        {
            // Skip the Items if equal
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            int j = i + 1;
            int k = nums.Length - 1;

            while (j < k)
            {
                int sum = nums[i] + nums[j] + nums[k];
                if (sum == 0)
                {
                    result.Add(new List<int>() { nums[i], nums[j], nums[k] });
                    while (j < k && nums[j] == nums[j + 1]) j++;
                    while (j < k && nums[k] == nums[k - 1]) k--;
                    j++;
                    k--;
                }
                else if (sum < 0)
                {
                    j++;
                }
                else
                {
                    k--;
                }
            }
        }

        return result;
    }
}
