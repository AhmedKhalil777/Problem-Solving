using System.ComponentModel;

namespace LeetCode.Algorithms;

public class NearestExitfromEntranceinMaze
{
    static bool[,] visited;
    public static int NearestExit(char[][] maze, int[] entrance)
    {
        var exits = FindExits(maze, entrance).Distinct();
        var res = int.MaxValue;
        foreach (var exit in exits)
        {
            if (Math.Abs(exit[0] - entrance[0]) >= res && Math.Abs(exit[0] - entrance[0]) >= res)
            {
                continue;
            }
            var path = FindShortestPathLength(maze, entrance, exit);
            if (path == -1 ) continue;
            if (path < res) res = path;
        }

        if (res == int.MaxValue) res = -1;
        return res;
    }

    static List<int[]> FindExits(char[][] maze, int[] entrance)
    {
        var res = new List<int[]>();
        var height = maze.Length;
        var width = maze[0].Length;
        for (int i = 0; i < width; i++)
        {
            if (maze[0][i] == '.' && ( entrance[0] !=  0 || entrance[1] != i))
            {
                res.Add(new []{0, i});
            }

        }

        for (int i = 0; i < height; i++)
        {
            if (maze[i][0] == '.' && (entrance[0] != i || entrance[1] != 0))
            {
                res.Add(new[] { i, 0 });
            }
        }

        for (int i = 0; i < width; i++)
        {

            if (maze[height - 1][i] == '.' && (entrance[0] != height - 1 || entrance[1] != i))
            {
                res.Add(new[] { height - 1, i});
            }
        }

        for (int i = 0; i < height; i++)
        {

            if (maze[i][width - 1] == '.' && (entrance[0] != i || entrance[1] != width - 1))
            {
                res.Add(new[] { i, width - 1 });
            }
        }

        return res;
    }

    static int FindShortestPathLength(char[][] maze,
        int[] src, int[] dest)
    {
        if (maze.Length == 0
            || maze[src[0]][src[1]] == 0
            || maze[dest[0]][dest[1]] == 0)
            return -1;

        int row = maze.Length;
        int col = maze[0].Length;

// construct an `M × N` matrix to keep track of
// visited cells
        visited = new bool[row, col];
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
                visited[i, j] = false;
        }

        int dist = Int32.MaxValue;
        dist = FindShortestPath(maze, src[0], src[1],
            dest[0], dest[1], dist, 0);

        if (dist != Int32.MaxValue)
            return dist;
        return -1;
    }

    static int FindShortestPath(char[][] mat, int i, int j,
        int x, int y, int min_dist,
        int dist)
    {

        if (i == x && j == y)
        {
            min_dist = Math.Min(dist, min_dist);
            return min_dist;
        }

        // set (i, j) cell as visited
        visited[i, j] = true;
        // go to the bottom cell
        if (IsSafe(mat, visited, i + 1, j))
        {
            min_dist = FindShortestPath(mat, i + 1, j, x, y,
                min_dist, dist + 1);
        }
        // go to the right cell
        if (IsSafe(mat, visited, i, j + 1))
        {
            min_dist = FindShortestPath(mat, i, j + 1, x, y,
                min_dist, dist + 1);
        }
        // go to the top cell
        if (IsSafe(mat, visited, i - 1, j))
        {
            min_dist = FindShortestPath(mat, i - 1, j, x, y,
                min_dist, dist + 1);
        }
        // go to the left cell
        if (IsSafe(mat, visited, i, j - 1))
        {
            min_dist = FindShortestPath(mat, i, j - 1, x, y,
                min_dist, dist + 1);
        }
        // backtrack: remove (i, j) from the visited matrix
        visited[i, j] = false;
        return min_dist;
    }

    static bool IsSafe(char[][] mat, bool[,] visited, int x,
        int y)
    {
        return (x >= 0 && x < mat.Length && y >= 0
                && y < mat[0].Length && mat[x][y] == '.'
                && !visited[x, y]);
    }
}

