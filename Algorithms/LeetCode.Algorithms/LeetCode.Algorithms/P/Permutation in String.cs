using System.Text;

namespace LeetCode.Algorithms;

public static class Permutation_in_String
{
    public static bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length)
            return false;
        int[] s1map = new int[26];
        int[] s2map = new int[26];
        for (int i = 0; i < s1.Length; i++)
        {
            s1map[s1[i] - 'a']++;
            s2map[s2[i] - 'a']++;
        }

        int count = 0;
        for (int i = 0; i < 26; i++)
        {
            if (s1map[i] == s2map[i])
                count++;
        }

        for (int i = 0; i < s2.Length - s1.Length; i++)
        {
            int r = s2[i + s1.Length] - 'a', l = s2[i] - 'a';
            if (count == 26)
                return true;
            s2map[r]++;
            if (s2map[r] == s1map[r])
            {
                count++;
            }
            else if (s2map[r] == s1map[r] + 1)
            {
                count--;
            }
            s2map[l]--;
            if (s2map[l] == s1map[l])
            {
                count++;
            }
            else if (s2map[l] == s1map[l] - 1)
            {
                count--;
            }
        }
        return count == 26;
    }

}
