namespace HackerRank.Algorithms;

public static class LibraryFine
{
    /*
 * Complete the 'libraryFine' function below.
 *
 * The function is expected to return an INTEGER.
 * The function accepts following parameters:
 *  1. INTEGER d1
 *  2. INTEGER m1
 *  3. INTEGER y1
 *  4. INTEGER d2
 *  5. INTEGER m2
 *  6. INTEGER y2
 */

    public static int libraryFine(int d1, int m1, int y1, int d2, int m2, int y2)
    {
        var actualDateTime = new DateTime(y1, m1, d1);
        var expectedDateTime = new DateTime(y2, m2, d2);
        if (actualDateTime <= expectedDateTime) return 0;
        else if (y2 == y1 && m2 == m1) return (d1 - d2) * 15;
        else if (y2 == y1) return (m1 - m2) * 500;
        else return 10000;
        
    }
}
