namespace HackerRank.Algorithms;

public class AngryProfessor
{
    /*
* Complete the 'angryProfessor' function below.
*
* The function is expected to return a STRING.
* The function accepts following parameters:
*  1. INTEGER k
*  2. INTEGER_ARRAY a
*/

    public static string angryProfessor(int k, List<int> a)
    {
        var sum = Math.Abs(a.Count(x => x <= 0));
        return (sum >= k) ? "NO" : "YES";

    }
}