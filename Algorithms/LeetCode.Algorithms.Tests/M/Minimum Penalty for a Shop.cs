using Microsoft.Scripting.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Tests.M
{
    public class Minimum_Penalty_for_a_Shop
    {

        public int BestClosingTime(string customers)
        {

            customers = customers.TrimEnd('N');
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
}
