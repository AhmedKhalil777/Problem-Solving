namespace HackerRank.Algorithms;

public class HurdleRace
{
    public static int hurdleRace(int k, List<int> height)
    {
       var doses =  height.Max() - k;
       return doses >= 0 ? doses : 0;
    }
}