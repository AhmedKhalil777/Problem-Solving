namespace LeetCode.Algorithms;

public static class IsomorphicStrings
{

    public static bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }
        var dict = new Dictionary<char, char>();
        var rdict = new Dictionary<char, char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (dict.TryGetValue(s[i], out char c))
            {
                if (t[i] != c)
                {
                    return false;
                }
                continue;
            }

            if (rdict.TryGetValue(t[i], out char cc))
            {
                if (s[i] != cc)
                {
                    return false;
                }
                continue;
            }
            dict.TryAdd(s[i], t[i]);
            rdict.TryAdd(t[i], s[i]);
        }

        return true;

    }
}
