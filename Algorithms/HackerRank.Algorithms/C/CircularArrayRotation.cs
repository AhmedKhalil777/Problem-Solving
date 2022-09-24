namespace HackerRank.Algorithms;

public static class CircularArrayRotation
{

    public static List<int> circularArrayRotation(List<int> a, int k, List<int> queries)
    {
        var aLen = a.Count;
        k %= aLen;
        return queries.Select(q =>
        {
            var index = q - k;
            if (index < 0)
            {
                index += aLen;
            }
            return a[index];
        }).ToList();
    }
}
