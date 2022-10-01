namespace HackerRank.Algorithms;

public static class RepeatedString
{
    /*
 * Complete the 'repeatedString' function below.
 *
 * The function is expected to return a LONG_INTEGER.
 * The function accepts following parameters:
 *  1. STRING s
 *  2. LONG_INTEGER n
 */

    public static long repeatedString(string s, long n)
    {
        var ch = 'a';
        if (!s.Any(x=> x == ch))
        {
            return 0;
        }
        var count = s.Count(x => x == ch);
        long result = 0;
        long repeatings =  (n / s.Length);
        result += (count * repeatings);
        var remaining = n % s.Length;
        if (remaining == 0 )
        {
            return result;
        }
        var substr = s.Substring(0, (int)remaining);
        result += substr.Count(x => x == ch);
        return result;
    }
}
