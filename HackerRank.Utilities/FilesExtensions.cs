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

    public static List<List<int>> ReadLinesAsMatrix(this string path)
    {
        return File.ReadLines(path)
            .Select(x =>  x.Split(' ')
                                .Select(y => int.Parse(y))
                                .ToList())
            .ToList();
    }
    
    public static List<int> ReadLinesAsVector(this string path)
    {
        return File.ReadLines(path)
            .Select(y => int.Parse(y)).ToList();
    }
}