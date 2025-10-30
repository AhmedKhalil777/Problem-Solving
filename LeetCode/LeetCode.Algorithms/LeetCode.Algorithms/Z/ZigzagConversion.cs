using System.Text;

namespace LeetCode.Algorithms;

public static class ZigzagConversion
{
    public static string Convert(string s, int numRows)
    {
        if (numRows ==1)
        {
            return s;
        }

        var ordering = new List<Tuple<int, char>>();
        var i = 0;
        var dir = 1;
        foreach (var c in s)
        {
            ordering.Add(new Tuple<int, char>(i, c));
            
            if (i == numRows -1)
            {
                dir = -1;
            }
            else if (i == 0)
            {
                dir = 1;
            }
            
            i = dir == 1 ? i + 1 : i-1;
        }
        var sb = new StringBuilder();
        for (int j = 0; j < numRows; j++)
        {
            sb.Append(string.Join(string.Empty,ordering.Where(x => x.Item1 == j).Select(x => x.Item2)));
        }

        return sb.ToString();

    }
}
