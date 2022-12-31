using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms;

public static class Queen_s_Attack_II
{
    /*
 * Complete the 'queensAttack' function below.
 *
 * The function is expected to return an INTEGER.
 * The function accepts following parameters:
 *  1. INTEGER n
 *  2. INTEGER k
 *  3. INTEGER r_q
 *  4. INTEGER c_q
 *  5. 2D_INTEGER_ARRAY obstacles
 */

    public static List<Tuple<int, int>> QueenSteps = new List<Tuple<int, int>>()
    {
        new(0,1),
        new(0,-1),
        new(1,0),
        new(-1,0),
        new (1,1),
        new (1,-1),
        new (-1,-1),
        new (-1,1),
    };
    public static int queensAttack(int n, int k, int r_q, int c_q, List<List<int>> obstacles)
    {
        var res = 0;

        var cleanObstacles = new List<List<int>>();

        foreach (var obs in obstacles)
        {
            int rdif = obs[0] - r_q;
            int cdif = obs[1] - c_q;
            if (rdif == cdif || rdif == -cdif || rdif == 0 || cdif == 0)
            {
                cleanObstacles.Add(obs);
            }
        }

        foreach (var step in QueenSteps)
        {
            var i = r_q - 1;
            var j = c_q - 1;
            while (true)
            {
                i += step.Item1;
                j += step.Item2;
                if (i >= 0 && j >= 0 && i < n && j < n && !cleanObstacles.Any(x=> x[0] == i+1 && x[1] == j+1) )
                {
                    res++;
                }
                else
                {
                    break;
                }

            }
        }

        return res;

    }
}
