namespace HackerRank.Algorithms;

public class CatsAndAMouse
{
    // Complete the catAndMouse function below.
    public static string catAndMouse(int x, int y, int z)
    {
        var catACatch = Math.Abs(z - x);
        var catBCatch = Math.Abs(z - y);
        if (catACatch < catBCatch)
        {
            return "Cat A";
        } 
        return catBCatch < catACatch ? "Cat B" : "Mouse C";
    }

}