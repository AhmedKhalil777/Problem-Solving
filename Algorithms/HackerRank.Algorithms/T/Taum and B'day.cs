using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms;

public class Taum_and_B_day
{
    /*
 * Complete the 'taumBday' function below.
 *
 * The function is expected to return a LONG_INTEGER.
 * The function accepts following parameters:
 *  1. INTEGER b
 *  2. INTEGER w
 *  3. INTEGER bc
 *  4. INTEGER wc
 *  5. INTEGER z
 */

    public static long taumBday(int b, int w, int bc, int wc, int z)
    {
        var bl = (long)b;
        var wl = (long)w;
        var bcl = (long)bc;
        var wcl = (long)wc;
        var zl = (long)z;
        var res = 0L;
        res += bl * bcl < (bl * (wcl + zl)) ? bl * bcl : (bl * (wcl + zl));
        res += wl * wcl < (wl * (bcl + zl)) ? wl * wcl : (wl * (bcl + zl));
        return res;
    }
}
