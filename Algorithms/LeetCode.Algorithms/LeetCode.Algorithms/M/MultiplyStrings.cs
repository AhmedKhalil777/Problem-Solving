using static IronPython.Modules._ast;
using System.Numerics;

namespace LeetCode.Algorithms;

public class MultiplyStrings
{
    public string Multiply(string num1, string num2)
    {
        var x = BigInteger.Parse(num1);
        var y = BigInteger.Parse(num2);
        return (x * y).ToString();
    }
}
