namespace LeetCode.Algorithms;

public class Number_of_Islands
{
    public static List<Tuple<int, int>> Directions = new List<Tuple<int, int>>
    {
        new(1,0),
        new(0,1),
        new(-1,0),
        new(0,-1),
    };
    public static int NumIslands(char[][] grid)
    {
        int m = grid.Length;
        int n = grid[0].Length;
        bool[,] visited = new bool[m, n];
        int numIslands = 0;

        for (int r = 0; r < m; r++)
        {
            for (int c = 0; c < n; c++)
            {
                if (visited[r, c] || grid[r][c] != '1')
                    continue;
                TryVisit(grid, r, c, visited, m, n);
                numIslands++;
            }
        }

        return numIslands;
    }

    public static void TryVisit(char[][] grid, int r, int c, bool[,] visited, int m, int n)
    {
        if (r < 0 || c < 0 || r >= m || c >= n || visited[r, c] || grid[r][c] != '1')
        {
            return;
        }

        visited[r, c] = true;

        foreach (var (rD , cD) in Directions)
        {
            TryVisit(grid, r + rD, c + cD, visited, m, n);

        }
    }
}
