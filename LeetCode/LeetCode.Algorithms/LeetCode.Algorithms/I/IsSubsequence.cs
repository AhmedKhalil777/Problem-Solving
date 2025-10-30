namespace LeetCode.Algorithms;

public static class IsSubsequenceC
{
    public static bool IsSubsequence(string s, string t)
    {
        for (int i = 0; i < s.Length; i++)
        {
            if (!t.Contains(s[i]))
            {
                return false;
            }
            t = t[(t.IndexOf(s[i])+1)..];
        }

        return true;
    }
}
