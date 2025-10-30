using System.Text;

namespace LeetCode.Algorithms;

public static class LongestCommonPrefix
{
    public static string LongestCommonPrefixM(string[] strs)
    {
        var minStrLength = strs.Min(str => str.Length);
        var sb = new StringBuilder();
        int n = 0;
        bool finish = false;
        while (n < minStrLength)
        {
            if (strs[0].Length == n) break;
            var ch = strs[0][n];
            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i].Length == n) break;
                if (strs[i][n] != ch)
                {
                    finish= true;
                    break;
                }
                if (i == strs.Length -1)
                {
                    sb.Append(ch);
                }
            }
            if (finish) break;
            n++;
        }

        return sb.ToString();


    }

    public static string LongestCommonPrefixM2(string[] strs)
    {
        var minStrLength = strs.Min(str => str.Length);
        var sb = new StringBuilder();
        if (minStrLength == 0)
        {
            return "";
        }

        for (int i = 0; i < minStrLength; i++)
        {
            var ch = strs[0][i];
            if (strs.All(s => s.StartsWith(sb.ToString() + ch)))
            {
                sb.Append(ch);
            }
            else
            {
                break;
            }
        }
        return sb.ToString();


    }
}
