namespace HackerRank.Algorithms;

public static class SalesByMatch
{
    
    /*
     * Complete the 'sockMerchant' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */

    public static int sockMerchant(int n, List<int> ar)
    {
       return ar.GroupBy(x => x)
            .Select(x => (x.Count() / 2))
            .Sum();
    }

}