namespace HackerRank.Algorithms;
public static class SaveThePrisoner
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="n">Number of prisoners</param>
    /// <param name="m">Count of candies</param>
    /// <param name="s">Start from</param>
    /// <returns></returns>
    public static int saveThePrisoner(int n, int m, int s)
    {
        var res =  (m % n) + s - 1;
        if (res == 0) return n;
        if (res <= n) return res;
        return res - n;
    }
}

