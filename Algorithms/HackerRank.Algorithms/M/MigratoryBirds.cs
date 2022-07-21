namespace HackerRank.Algorithms;

public class MigratoryBirds
{
    /*
 * Complete the 'migratoryBirds' function below.
 *
 * The function is expected to return an INTEGER.
 * The function accepts INTEGER_ARRAY arr as parameter.
 */

    public static int migratoryBirds(List<int> arr)
    {
        var queryable = arr.GroupBy(x => x)
            .Select(x => new Tuple<int, int>(x.Key, x.Count()));
        var maxSum = queryable.Max(x=> x.Item2);
        return queryable.Where(x=> x.Item2 == maxSum).Min(x=> x.Item1);
    }
}