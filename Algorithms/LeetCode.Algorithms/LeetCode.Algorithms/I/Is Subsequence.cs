namespace LeetCode.Algorithms;

public class Is_Subsequence
{
    public bool IsSubsequence(string s, string t)
    {
        if (s.Length == 0)
        {
            return true;
        }
        var si = 0;
        for (int i = 0; i < t.Length; i++)
        {
            if ((s.Length - si) > (t.Length -i))
            {
                return false;
            }
            if (s[si] == t[i])
            {
                si++;
            }
            if (si == s.Length)
                return true;
        }
        return false;
    }
}
