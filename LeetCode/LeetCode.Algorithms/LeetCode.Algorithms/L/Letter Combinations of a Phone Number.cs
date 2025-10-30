using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.L
{
    public class Letter_Combinations_of_a_Phone_Number
    {

        public readonly Dictionary<char, string> PhoneLetterMap = new()
        {
            { '2', "abc" },
            { '3', "def" },
            { '4', "ghi" },
            { '5', "jkl" },
            { '6', "mno" },
            { '7', "pqrs" },
            { '8', "tuv" },
            { '9', "wxyz" }
        };

        public IList<string> LetterCombinations(string digits)
        {
            var res = new List<string>();
            if (string.IsNullOrEmpty(digits))
            {
                return res;
            }
            foreach (var  digit in digits)
            {
                res = AddCombination(res, digit);
            }

            return res;
        }


        public  List<string> AddCombination(List<string> input, char chr)
        {
            var valueMap = PhoneLetterMap[chr];

            var res = new List<string>();
            if (input.Count == 0)
            {
                foreach (var ch in valueMap)
                {
                    res.Add(ch.ToString());
                }
                return res;
            }
            foreach (var str in input)
            {
                foreach (var ch in valueMap)
                {
                    res.Add(str + ch);
                }
            }
           
            return res;

        }
    }
}
