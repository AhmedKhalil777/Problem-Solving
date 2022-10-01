using System.Collections.Generic;

namespace HackerRank.Algorithms;

public static class NonDivisibleSubset
{

    public static int nonDivisibleSubset(int k, List<int> s)
    {
        int[] frequency = new int[k];
        for (int i = 0; i < s.Count; i++)
        {
            frequency[s[i] % k] += 1;
        }
        int count = 0;
        if (frequency[0] > 0)
            count = 1;

        if (k % 2 == 0 && frequency[k / 2] > 0)
            count += 1;

        for (int i = 1, j = k - 1; i < j; i++, j--)
        {

            if (frequency[i] > frequency[j])
                count += frequency[i];
            else
                count += frequency[j];
        }
        return count;
    }


    #region Performance Leek Method
    /*
* Complete the 'nonDivisibleSubset' function below.
*
* The function is expected to return an INTEGER.
* The function accepts following parameters:
*  1. INTEGER k
*  2. INTEGER_ARRAY s
*/

    private static int maxSubset = 0;
    public static int nonDivisibleSubsetMethod1(int k, List<int> s)
    {
        if (maxSubset > s.Count)
            return maxSubset;
        if (!IsDevisibleSubset(k, s))
        {
            maxSubset = s.Count;
            return s.Count;
        }

        return GetSubsetsOf(s).Select(x => nonDivisibleSubset(k, x)).Max();
    }


    public static bool IsDevisibleSubset(int k, List<int> s)
    {
        for (int i = 0; i < s.Count; i++)
        {
            for (int j = 0; j < s.Count; j++)
            {
                if (i == j)
                    continue;
                if ((s[i] + s[j]) % k == 0)
                    return true;
            }
        }
        return false;
    }

    public static List<List<int>> GetSubsetsOf(List<int> s)
    {
        List<List<int>> subsets = new();
        for (int i = 0; i < s.Count; i++)
        {
            subsets.Add(s.Where(x => x != s[i]).ToList());
        }
        return subsets;
    }
    #endregion

}
