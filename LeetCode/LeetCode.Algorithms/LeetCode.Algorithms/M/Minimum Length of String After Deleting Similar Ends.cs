namespace LeetCode.Algorithms;

public class Minimum_Length_of_String_After_Deleting_Similar_Ends
{
    public int MinimumLength(string s)
    {
        if (string.IsNullOrEmpty(s)) return 0;
        int i = 0, j = s.Length - 1;
        while (j - i > 0)
        {
            var c = s[i];
            if (s[j] != c)
            {
                return j - i +1;
            }
            while (i< s.Length && s[i] == c)
            {
                i++;
            }
            while (j > 0 && s[j] == c)
            {
                j--;
            }
        }
        if (j-i == 0)
        {
            return 1;
        }

        return 0;
    }
}
