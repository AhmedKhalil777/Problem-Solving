namespace HackerRank.Algorithms;

public class CutTheSticks
{

    /*
 * Complete the 'cutTheSticks' function below.
 *
 * The function is expected to return an INTEGER_ARRAY.
 * The function accepts INTEGER_ARRAY arr as parameter.
 */

    public static List<int> cutTheSticks(List<int> arr)
    {
        var output = new List<int>(); 
        while(arr.Any(x => x > 0))
        {
            arr= arr.Where(x => x > 0).ToList();
            var min = arr.Min();
            arr = arr.Select(x => x - min).ToList();
            output.Add(arr.Count);
        }
        return output;
    }

}
