namespace HackerRank.DataStructures;

public class DynamicArray
{
    /*
 * Complete the 'dynamicArray' function below.
 *
 * The function is expected to return an INTEGER_ARRAY.
 * The function accepts following parameters:
 *  1. INTEGER n
 *  2. 2D_INTEGER_ARRAY queries
 */

    public static List<int> dynamicArray(int n, List<List<int>> queries)
    {
        var lastAnswer = 0;
        var arr =Enumerable.Range(0, n).Select(x=> new List<int>()).ToList();
        var results = new List<int>();
        foreach (var query in queries)
        {
            if (query[0] == 1)
            {
               arr[(query[1] ^ lastAnswer) % n].Add(query[2]); 
               continue;
            }

            lastAnswer = arr[(query[1] ^ lastAnswer) % n][query[2] % arr[(query[1] ^ lastAnswer) % n].Count];
            results.Add(lastAnswer);
        }

        return results;

    }
}