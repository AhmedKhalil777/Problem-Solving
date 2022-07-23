namespace HackerRank.Algorithms.Tests;

public static class StringExtensions
{
    public static List<int> AsStringIntList(this string serial)
    {
        return serial.Split(' ').Select(x => int.Parse(x)).ToList();
    }
}