namespace HackerRank.Algorithms;

public static class SherlockAndSquares
{
    /*
 * Complete the 'squares' function below.
 *
 * The function is expected to return an INTEGER.
 * The function accepts following parameters:
 *  1. INTEGER a
 *  2. INTEGER b
 */

    public static int squares(int a, int b)
    {
        var aSqrt = (int) Math.Sqrt(a);
        var i = 0;
        while(Math.Pow(aSqrt,2) <= b)
        {
            if (Math.Pow(aSqrt,2) >= a )
            {
                i++;
            }
            aSqrt++;
        }
        return i;
    }
}
