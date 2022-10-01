namespace HackerRank.Algorithms;

public class AppendAndDelete
{
    /*
 * Complete the 'appendAndDelete' function below.
 *
 * The function is expected to return a STRING.
 * The function accepts following parameters:
 *  1. STRING s
 *  2. STRING t
 *  3. INTEGER k
 */

    public static string appendAndDelete(string s, string t, int k)
    {
        String result = "No";
        if (s==t)
        {
           return "Yes";
        }
        else
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i < t.Length)
                {
                    if (s[i] == t[i])
                        count++;
                    else
                        break;
                }
            }
            int left = s.Length - count;
            int need = t.Length - count;

            if (k >= s.Length + t.Length)
            {
                result = "Yes";
            }
            else if (k >= (left + need))
            {
                if ((need + left) % 2 != 0)
                {
                    if (k % 2 != 0)
                        result = "Yes";
                }
                else
                {
                    if (k % 2 == 0)
                        result = "Yes";
                }
            }
        }
        return result;
    }

}
