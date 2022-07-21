namespace HackerRank.Algorithms;

public class BillDivision
{
    /*
 * Complete the 'bonAppetit' function below.
 *
 * The function accepts following parameters:
 *  1. INTEGER_ARRAY bill
 *  2. INTEGER k
 *  3. INTEGER b
 */

    public static string Result { get; private set; }

    public static void bonAppetit(List<int> bill, int k, int b)
    {
        bill[k] = 0;
        var brianPocketAfterBay =b - (bill.Sum() /2);
        Result = brianPocketAfterBay > 0 ? $"{brianPocketAfterBay}" : "Bon Appetit";
        Console.WriteLine(Result);
    }
}