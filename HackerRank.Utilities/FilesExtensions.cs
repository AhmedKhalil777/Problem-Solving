namespace HackerRank.Utilities;

public static class FilesExtensions
{
    public static List<int> AsFileIntList(this string path)
    {
       return File.ReadAllText(path).Split(' ').Select(x => int.Parse(x)).ToList();
    }
    
    public static int[] AsFileIntArray(this string path)
    {
        return File.ReadAllText(path).Split(' ').Select(x => int.Parse(x)).ToArray();
    }
}