namespace HackerRank.DataStructures;

public class SparseArrays
{
    public static List<int> matchingStrings(List<string> strings, List<string> queries)
    {
        return queries.Select(query => strings.Count(x => x == query)).ToList();
    }
}