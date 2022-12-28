using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms;

public static class Reverse_Words_in_a_String_III
{
    public static string ReverseWords(string s)
    {
        return string.Join(" ", s.Split(' ').Select(x => string.Concat(x.Reverse())));
    }
}
