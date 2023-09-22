using Microsoft.Scripting.Utils;

namespace LeetCode.Algorithms;

public class Minimum_Penalty_for_a_Shop
{
    public int BestClosingTime(string customers)
    {
        int[] cnt = new int[2], cnt2 = new int[2];
        for (int i = 0; i < customers.Length; i++)
            cnt[customers[i] == 'Y' ? 1 : 0]++;
        int minPenalty = cnt[1], penalty;
        int pos = 0;
        for (int i = 1; i <= customers.Length; i++)
        {
            cnt2[customers[i - 1] == 'Y' ? 1 : 0]++;
            penalty = cnt2[0] + (cnt[1] - cnt2[1]);
            if (penalty < minPenalty)
            {
                minPenalty = penalty;
                pos = i;
            }
        }
        return pos;
    }

    public int BestClosingTimeV1(string customers)
    {
        customers = customers.TrimEnd('N');
        if (string.IsNullOrEmpty(customers))
        {
            return 0;
        }
        var scores = new List<int>();
        var score = 0;
        foreach (var customer in customers)
        {
           
            if (customer == 'Y')
            {
                score++;
            }
            else
            {
                score--;
            }
            scores.Add(score);
        }
        var maxScore = scores.Max(x=> x);
        if (maxScore <=0)
        {
            return 0;
        }
        return scores.IndexOf(maxScore) +1;
    }
}
