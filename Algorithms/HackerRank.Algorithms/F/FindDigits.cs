namespace HackerRank.Algorithms;

public static class FindDigits
{

    /*
 * Complete the 'findDigits' function below.
 *
 * The function is expected to return an INTEGER.
 * The function accepts INTEGER n as parameter.
 */

    public static int findDigits(int n)
    {
        var s = n.ToString();
        var count = 0;
        foreach (var c in s)
        {
            if (c == '0') continue;
            if (n % int.Parse(c+"") == 0)
                count++;
        }
        return count;
    }

}
