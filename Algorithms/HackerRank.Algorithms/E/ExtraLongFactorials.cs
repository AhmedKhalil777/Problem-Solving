using System.Numerics;

namespace HackerRank.Algorithms;

public static class ExtraLongFactorials
{
    /*
 * Complete the 'extraLongFactorials' function below.
 *
 * The function accepts INTEGER n as parameter.
 */

    public static string extraLongFactorials(int n)
    {
        BigInteger bigInt = n;
        while (--n > 0)
        {
            bigInt *= n;
        }
        Console.WriteLine(bigInt);
        return bigInt.ToString();
    }
}
