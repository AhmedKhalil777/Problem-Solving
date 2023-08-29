using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms
{
    public class Organizing_Containers_of_Balls
    {
        public static string organizingContainers(List<List<int>> container)
        {

            for (int i = 0; i < container.Count; i++)
            {
                if (SumRow(i,container) != SumColumn(i, container))
                {
                    return "Impossible";
                }
            }

            return "Possible";
        }


        private static int SumColumn(int index, List<List<int>> container)
        {
            var sum = 0;
            for (int i = 0; i < container.Count; i++)
            {
                sum+= container[i][index];
            }
            return sum;
        }

        private static int SumRow(int index, List<List<int>> container)
        {
            var sum = 0;
            for (int i = 0; i < container.Count; i++)
            {
                sum += container[index][i];
            }
            return sum;
        }
    }
}
