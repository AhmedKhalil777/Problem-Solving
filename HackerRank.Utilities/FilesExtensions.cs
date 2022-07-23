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

    public static List<List<int>> ReadAsMatrix(this string path)
    {
        return File.ReadLines(path)
            .Select(x =>  x.Split(' ')
                                .Select(y => int.Parse(y))
                                .ToList())
            .ToList();
    }
}