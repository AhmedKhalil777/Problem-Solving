namespace HackerRank.Algorithms;

public static class AppleAndOrange
{
    public static Tuple<int,int> countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        var applesPalces = apples.Select(x => a + x);
        var orangePalces = oranges.Select(x => b + x);
        var applesOnSams = applesPalces.Count(x => x >= s && x <= t);
        var orangesOnSams = orangePalces.Count(x => x >= s && x <= t);
        Console.WriteLine(applesOnSams);
        Console.WriteLine(orangesOnSams);
        return new Tuple<int, int>(applesOnSams, orangesOnSams);
    }
}