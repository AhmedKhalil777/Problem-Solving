using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms;

public class ACM_ICPC_Team
{
    /*
 * Complete the 'acmTeam' function below.
 *
 * The function is expected to return an INTEGER_ARRAY.
 * The function accepts STRING_ARRAY topic as parameter.
 */

    public static List<int> acmTeam(List<string> topic)
    {
        var length = topic[0].Count();
        var maxTopicCount = 0;
        var maxMerges = 0;

        for (int i = 0; i < topic.Count; i++)
        {
            for (int j = i+1; j < topic.Count; j++)
            {
                var topicsCount = MergeTeam(length, topic[i], topic[j]);
                if (topicsCount > maxTopicCount)
                {
                    maxTopicCount = topicsCount;
                    maxMerges = 1;
                }
                else if(topicsCount == maxTopicCount)
                {
                    maxMerges++;
                }
            }
        }

         

        return new List<int> { maxTopicCount, maxMerges };
    }

    private static int MergeTeam(int n, string team1, string team2)
    {
        int res = 0;
        for (int i = 0; i < n; i++)
        {
            if (team1[i] == '1' || team2[i] == '1')
            {
                res++;
            }
        }
        return res;
    }

}
