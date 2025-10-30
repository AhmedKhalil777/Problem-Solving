namespace LeetCode.Algorithms;

public class Regular_Expression_Matching
{
    public bool IsMatch(string s, string p)
    {
        if (string.IsNullOrEmpty(p)) return string.IsNullOrEmpty(s);
        var firstMatch = (!string.IsNullOrEmpty(s) &&
                            (p[0] == s[0] || p[0] == '.'));

        if (p.Length >= 2 && p[1] == '*')
        {
            return (IsMatch(s, p[2..]) ||
                    (firstMatch && IsMatch(s[1..], p)));
        }

        return firstMatch && IsMatch(s[1..], p[1..]);
    }
}