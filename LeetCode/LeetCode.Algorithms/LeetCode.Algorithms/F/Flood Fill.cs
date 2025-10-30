namespace LeetCode.Algorithms;

public static class Flood_Fill
{
    public static List<Tuple<int, int>> Directions = new List<Tuple<int, int>>
    {
        new(1,0),
        new(0,1),
        new(-1,0),
        new(0,-1),
    };
    public static int[][] FloodFill(int[][] image, int sr, int sc, int color)
    {
        var prevColor = image[sr][sc];
        if (prevColor == color)
        {
            return image;
        }

        Color( image, sr, sc, prevColor, color);
        return image;
    }

    public static void Color(int[][] image, int sr, int sc, in int prevColor,int color)
    {
        if (sr < 0 || sr >= image.Length || sc <0 || sc>= image[0].Length )
        {
            return;
        }
        if (prevColor != image[sr][sc] )
        {
            return;
        }
        image[sr][sc] = color;
        
        foreach (var dir in Directions)
        {
            Color( image, sr + dir.Item1, sc + dir.Item2, prevColor, color);

        }
    }
}
