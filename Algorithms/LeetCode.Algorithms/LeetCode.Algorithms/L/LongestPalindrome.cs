namespace LeetCode.Algorithms;


public class LongestPalindrome
{
    public static int LongestPalindromeM(string s)
    {
        var dict = new Dictionary<char, int>();
        foreach (var c in s)
        {
            if (dict.ContainsKey(c))
            {
                 dict[c]++;
            }
            else
            {
                dict.Add(c, 1);
            }
        }
        var containsOdds = dict.Any(x => x.Value % 2 == 1);
        var evens = dict.Select(x=> x.Value /2).Sum() * 2;
        return containsOdds ? evens + 1 : evens;
    }
}

public class LongestPalindromeI
{
    // Manacher's algorithm
    public static string LongestPalindromeIII(string s)
    {
        /*
        If length of given string is n then its length after
        inserting n+1 "#", one "@", and one "$" will be
        (n) + (n+1) + (1) + (1) = 2n+3
       */
        int strLen = 2 * s.Length + 3;
        char[] sChars = new char[strLen];

        /*
         Inserting special characters to ignore special cases
         at the beginning and end of the array
         "abc" -> @ # a # b # c # $
         "" -> @#$
         "a" -> @ # a # $
        */
        sChars[0] = '@';
        sChars[strLen - 1] = '$';
        int t = 1;
        foreach (char c in s.ToList())
        {
            sChars[t++] = '#';
            sChars[t++] = c;
        }
        sChars[t] = '#';

        int maxLen = 0;
        int start = 0;
        int maxRight = 0;
        int center = 0;
        int[] p = new int[strLen]; // i's radius, which doesn't include i
        for (int i = 1; i < strLen - 1; i++)
        {
            if (i < maxRight)
            {
                p[i] = Math.Min(maxRight - i, p[2 * center - i]);
            }

            // Expanding along the center
            while (sChars[i + p[i] + 1] == sChars[i - p[i] - 1])
            {
                p[i]++;
            }

            // Updating center and its bound
            if (i + p[i] > maxRight)
            {
                center = i;
                maxRight = i + p[i];
            }

            // Updating ans
            if (p[i] > maxLen)
            {
                start = (i - p[i] - 1) / 2;
                maxLen = p[i];
            }
        }
        var res =  s.Substring(start, start + maxLen - 1);

        if (IsPalindrome(res))
        {
            return res;
        }
        return s.Substring(start, start + maxLen);
    }
    public static string Scan(string s)
    {
        int i = 0;
        int j= s.Length;
        while (j != i)
        {
            for (int k = 0 ; k <= i; k++)
            {
                var sub = s.Substring(k, j - i);
                if (IsPalindrome(sub))
                {
                    return sub;
                }
            }
            i++;
        }
        return "";
    }


    public static bool IsPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s) || s.Length < 2)
        {
            return false;
        }
        int sep =s.Length %2 == 0 ? s.Length / 2 : s.Length / 2 + 1;
        var firstSection = s[..sep];
        var secondSection = string.Join("", s.Reverse())[..sep];
        return firstSection == secondSection;
    }
}
