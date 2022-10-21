using System.Text;

namespace LeetCode.Algorithms;

public class LongestSubstring
{
    public static int LengthOfLongestSubstring(string s)
    {
        var maxSub = 0;
        var n = 0;
        var builder = new StringBuilder();
        foreach (var c in s)
        {
            if (builder.ToString().Any(x => x == c))
            {
                var res = builder.ToString();
                var index = res.LastIndexOf(c) + 1;
                res = res[index..];
                builder.Clear();
                builder.Append(res);
                n = 0;
            }
            builder.Append(c);
            n = builder.Length;
            if (n > maxSub) maxSub = n;
        }
        return maxSub;
    }
}
