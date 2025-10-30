namespace LeetCode.Algorithms;

public class PalindromeNumber
{
    public static bool IsPalindrome(int x)
    {
        var xStr = x.ToString();
        var r = string.Join(string.Empty, xStr.Reverse());
        return r.Equals(xStr);
    }
}
