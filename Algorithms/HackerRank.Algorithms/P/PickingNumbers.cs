namespace HackerRank.Algorithms;

public class PickingNumbers
{
    // I think it is bad but it works
    public static int pickingNumbers(List<int> a)
    {
        var streaks = new List<List<int>>();
        for (int i = 0; i < a.Count; i++)
        {
            streaks.Add(a.Where(x=> x - a[i] == 1  ||  x - a[i] == 0).ToList());
            streaks.Add(a.Where(x=> x - a[i] == -1  ||  x - a[i] == 0 ).ToList());
        }

        return streaks.Select(x => x.Count).Max();
    }

}