namespace HackerRank.Algorithms;

public static class CountingValleys
{
    /*
* Complete the 'countingValleys' function below.
*
* The function is expected to return an INTEGER.
* The function accepts following parameters:
*  1. INTEGER steps
*  2. STRING path
*/

    public static int countingValleys(int steps, string path)
    {
        var seaLevel = 0;
        var hikerLevel = 0;
        var prevStep = 0;
        var valleys = 0;
        foreach (var move in path)
        {
            if (move == 'U')
                hikerLevel++;
            else
                hikerLevel--;
            if (prevStep >= seaLevel && hikerLevel < seaLevel)
            {
                valleys++;
            }

            prevStep = hikerLevel;
        }

        return valleys;
    }
    
    
}