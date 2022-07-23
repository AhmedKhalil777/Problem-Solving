namespace HackerRank.Algorithms;

public class ViralAdvertising
{
    /*
 * Complete the 'viralAdvertising' function below.
 *
 * The function is expected to return an INTEGER.
 * The function accepts INTEGER n as parameter.
 */

    public static int viralAdvertising(int n)
    {
        var people = 5.0;
        var cum = 0.0;
        for (var i = 0; i < n; i++)
        {
            var liked = Math.Floor(people / 2);
            cum += liked;
            people = liked * 3;
        }

        return (int) cum;
    }
}