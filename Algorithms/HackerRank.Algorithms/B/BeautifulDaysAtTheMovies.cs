namespace HackerRank.Algorithms;

public class BeautifulDaysAtTheMovies
{
    /*
 * Complete the 'beautifulDays' function below.
 *
 * The function is expected to return an INTEGER.
 * The function accepts following parameters:
 *  1. INTEGER i
 *  2. INTEGER j
 *  3. INTEGER k
 */

    public static int beautifulDays(int i, int j, int k)
    {
        var res = 0;
        for ( ; i <= j; i++)
        {
            var reverse = ReverseNum(i);
            if ((Math.Abs(reverse - i) % k) == 0)
                res++;
        }
        return res;
    }


    public static int ReverseNum(int num)
    {
        var numStr = num.ToString().ToList();
        var reverser = 1;
        var res = 0;
        for (var i = 0; i < numStr.Count(); i++)
        {
            res += int.Parse(numStr[i].ToString()) * reverser; 
            reverser *= 10;
        }

        return res;
    }
}