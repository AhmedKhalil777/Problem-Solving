using System.Linq;

namespace LeetCode.Algorithms;

public static class Two_Sum_II
{
    /// <summary>
    /// The numbers are sorted so use the binary search is the valuable algorithm
    /// </summary>
    /// <param name="numbers"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public static int[] TwoSum(int[] numbers, int target)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            var j = BinarySearch.Search(numbers, target - numbers[i]);
            if (j!= -1)
            {
                if (i == j)
                {
                    ++j;
                    return new int[] { ++i, ++j };
                }
                return new int[] { ++i, ++j };
            }
        }
        return null;   

    }


}
