namespace HackerRank.Algorithms.Tests;

public static class FilesExtensions
{
    public static List<int> AsIntList(this string path)
    {
       return File.ReadAllText(path).Split(' ').Select(x => int.Parse(x)).ToList();
    }
    
    public static int[] AsIntArray(this string path)
    {
        return File.ReadAllText(path).Split(' ').Select(x => int.Parse(x)).ToArray();
    }
}