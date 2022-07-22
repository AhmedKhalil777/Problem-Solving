namespace HackerRank.Algorithms;

public class FormingAMagicSquare
{
    /*
 * Complete the 'formingMagicSquare' function below.
 *
 * The function is expected to return an INTEGER.
 * The function accepts 2D_INTEGER_ARRAY s as parameter.
 */

    public static int formingMagicSquare(List<List<int>> s)
    {
        var totals = new List<int>();
        foreach (var mirror in MirrorsAndRotations)
        {
            var total = 0;
            var mirrorZipped = mirror.Zip(s);
            foreach (var zip in mirrorZipped)
            {
                for (var i = 0; i < 3; i++)
                {
                    if (zip.First[i] == zip.Second[i]) continue;
                    var unMatched = new List<int>() { zip.First[i], zip.Second[i] };
                    total += unMatched.Max() - unMatched.Min();
                }
            }
            totals.Add(total);
            
        }

        return totals.Min();
    }


    private static List<int[][]> MirrorsAndRotations = new ()
    {
        new int[][] { new[] { 8, 1, 6 }, new[] { 3, 5, 7 }, new[] { 4, 9, 2 } },
        new int[][] { new[] { 6, 1, 8 }, new[] { 7, 5, 3 }, new[] { 2, 9, 4 } },
        new int[][] { new[] { 4, 9, 2 }, new[] { 3, 5, 7 }, new[] { 8, 1, 6 } },
        new int[][] { new[] { 2, 9, 4 }, new[] { 7, 5, 3 }, new[] { 6, 1, 8 } },
        new int[][] { new[] { 8, 3, 4 }, new[] { 1, 5, 9 }, new[] { 6, 7, 2 } },
        new int[][] { new[] { 4, 3, 8 }, new[] { 9, 5, 1 }, new[] { 2, 7, 6 } },
        new int[][] { new[] { 6, 7, 2 }, new[] { 1, 5, 9 }, new[] { 8, 3, 4 } },
        new int[][] { new[] { 2, 7, 6 }, new[] { 9, 5, 1 }, new[] { 4, 3, 8 } },

    };

}