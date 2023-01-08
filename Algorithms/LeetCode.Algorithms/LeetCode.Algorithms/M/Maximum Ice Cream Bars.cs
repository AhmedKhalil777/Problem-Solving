using Microsoft.Scripting.Runtime;

namespace LeetCode.Algorithms;

public class Maximum_Ice_Cream_Bars
{

    public static int MaxIceCream(int[] costs, int coins)
    {
        var max = costs.Max(x => x);
        var freqMatrix = new int[max + 1];
        var res = 0;
        foreach (var cost in costs)
        {
            freqMatrix[cost] = freqMatrix[cost] +1;
        }
        for (int i = 1; i < freqMatrix.Length; i++)
        {
            if (freqMatrix[i] == 0)
            {
                continue;
            }
            if(coins < i)
            {
                break;
            }
            int count = Math.Min(freqMatrix[i], coins / i);
            coins -= i * count;
            res += count;

        }
        return res;
    }
    public static int MaxIceCreamM1(int[] costs, int coins)
    {
        Array.Sort(costs);
        var res = 0;
        for (int i = 0; i < costs.Length; i++)
        {
            if (coins < costs[i])
            {
                return res;
            }
            coins -= costs[i];
            res++;
        }
        return res;
    }
}
