namespace HackerRank.Algorithms;

public static class Equalize_the_Array
{
    /*
 * Complete the 'equalizeArray' function below.
 *
 * The function is expected to return an INTEGER.
 * The function accepts INTEGER_ARRAY arr as parameter.
 */

    public static int equalizeArray(List<int> arr)
    {
        var arrLen = arr.Count;
        var dict =arr.GroupBy(x=> x);
        var max = dict.Max(x => x.Count());
        return arrLen - max;
    }
}
