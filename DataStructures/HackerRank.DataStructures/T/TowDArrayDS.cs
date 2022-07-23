namespace HackerRank.DataStructures;

public class TowDArrayDS
{
    /*
 * Complete the 'hourglassSum' function below.
 *
 * The function is expected to return an INTEGER.
 * The function accepts 2D_INTEGER_ARRAY arr as parameter.
 */

    public static int hourglassSum(List<List<int>> arr)
    {
        var a = arr.Select(x => x.ToArray()).ToArray();
        var results = new List<int>();
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                results.Add(GetHourGlassSum(i,j, a));
            }
        }

        return results.Max();
    }

    public static int GetHourGlassSum(int i, int j, int[][] a)
    {
        var sum = 0;
        for (int k = i; k < i+3; k++)
        {
            for (int l = j ; l < j+3; l++)
            {
                if (k == i+1 &&  l == j+2 || k == i+1  && l == j) continue;
                sum += a[k][l];
            }
        }

        return sum;
    }
    
    
}