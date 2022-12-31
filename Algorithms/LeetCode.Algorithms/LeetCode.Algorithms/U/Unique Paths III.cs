using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms;

public static class Unique_Paths_III
{

    private static int[][] Steps = new int[][] {
            new int[]{0,1}, new int[]{0, -1},new int[] {-1, 0}, new int[]{1, 0}
    };
    public static int UniquePathsIII(int[][] grid)
    {
        var res = 0;
        var walks = 0;
        int row = 0, col = 0;
        // Getting the number of steps should be walked
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 0)
                {
                    walks++;
                }
                else if (grid[i][j] == 1)
                {
                    row = i;
                    col = j;
                }
            }
        }
        DFS(grid, row, col, 0,  walks, ref res);
        return res;
    }

    private static void DFS(int[][] grid, int row, int col, int walked, in int walks , ref int res)
    {
        // Exit Step no result
        // In Case Out of Cell or Obstacle
        if (row < 0 || row >= grid.Length || col < 0
                || col >= grid[row].Length || grid[row][col] < 0)
        {
            return;
        }
        // Exit Step with result
        // When reach end and Walk all steps
        if (grid[row][col] == 2 && walked == walks + 1)
        {
            res++;
            return;
        }

        int val = grid[row][col];

        // Make the comming back impossible
        grid[row][col] = -2;

        foreach (var step in Steps)
        {
            DFS(grid, row + step[0], col + step[1], walked + 1,  walks,ref res);
        }
        // Return back the val after move 
        grid[row][col] = val;
    }
}
