namespace LeetCode.Algorithms;

public class TowSum
{
    public static int[] TwoSum(int[] nums, int target)
    {
        var res = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    res.Add(i);
                    res.Add(j);
                }
            }
        }
        return res.ToArray();
    }
}
