namespace HackerRank.Algorithms;

public class DrawingBook
{
    /*
 * Complete the 'pageCount' function below.
 *
 * The function is expected to return an INTEGER.
 * The function accepts following parameters:
 *  1. INTEGER n
 *  2. INTEGER p
 */

    public static int pageCount(int n, int p)
    {
        var middle = n / 2;
        if (p <= middle)
          return p / 2;
        return n %2 == 0  && p % 2  == 1 ? ((n - p) / 2) +1 : (n - p) / 2;
    }
    
    

}