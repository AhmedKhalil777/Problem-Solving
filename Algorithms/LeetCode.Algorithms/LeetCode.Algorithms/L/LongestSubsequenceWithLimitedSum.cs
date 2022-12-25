using static IronPython.Modules._ast;
using System.Drawing;
using System.Xml.Linq;

namespace LeetCode.Algorithms;

public static class LongestSubsequenceWithLimitedSum
{
    public static int[] AnswerQueries(int[] nums, int[] queries)
    {
        //You are given an integer array nums of length n, and an integer array queries of length m.
        var n = nums.Length;
        var m = queries.Length;
        // Return an array answer of length m
        // where answer[i] is the maximum size of a subsequence
        // that you can take from nums such that the sum of its elements
        // is less than or equal to queries[i].
        var answer = new int[m];
        nums= nums.OrderBy(x => x).ToArray();
        for (int i = 0; i < m; i++)
        {
            var sum = 0;
            var j = 0;
            while( j < n)
            {
                sum += nums[j];
                if (sum <= queries[i])
                {
                    j++;
                }
                else
                {
                    break;
                }
            }
            answer[i] =j;
        }
        return answer;
    }
}
