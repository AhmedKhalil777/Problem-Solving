using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace LeetCode.Algorithms;

public class PermutationSequence
{
    public static string GetPermutation(int n, int k)
    {
        var fact = 1;
        var numbers =  new List<int>();
        var ans = "";
        foreach(var i in Enumerable.Range(1,n))
        {
            fact *= i;
            numbers.Add(i);
        }

        numbers.Add(n);
        k = k - 1;
        while (true)
        {
            ans = ans + numbers[(int)Math.Floor((decimal)k/fact)];

            numbers.RemoveAt((int)Math.Floor((decimal)k / fact));
            if (numbers.Count == 0)
                break;
            k = k % fact;
            fact = (int)Math.Floor((decimal)fact / numbers.Count);
        }

        return ans;

    }

    public static string GetCharForPermutation(int index,List<int> nums,int n, int k)
    {
        var fact = Factorial(n);
        var i = Math.Ceiling(((((double)k) / fact) * n)/index) -1;
        return nums[(int)i].ToString();
    }


    public static int Factorial(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        return n * Factorial(n - 1);
    }
}
