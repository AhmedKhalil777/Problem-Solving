namespace HackerRank.Algorithms;

public static class SubarrayDivision
{
    public static int birthday(List<int> s, int d, int m)
    {
        // # Possibilities;
        var p = 0;
        var i = 0;
        while (i + m <= s.Count)
        {
            var subArray = s.Skip(i).Take(m);
            if (subArray.Sum() == d)
                p++;
            i++;
        }
        return p;
    }
}