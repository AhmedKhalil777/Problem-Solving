using System.Numerics;

namespace LeetCode.Algorithms;

public class Plus_One
{

    public int[] PlusOne(int[] digits)
    {
        if (digits.Length == 0)
            return new int[0];

        List<int> rDigits = digits.Reverse().ToList();

        var hand = 1;
        for (var i = 0; i < rDigits.Count; i++)
        {
            rDigits[i] = hand + rDigits[i];
            hand = 0;
            if (rDigits[i] >= 10)
            {
                hand = rDigits[i] / 10;
                rDigits[i] = rDigits[i] % 10;
            }
            else
                break;
        }
        if (hand > 0)
            rDigits.Add(hand);

        int[] arr = new int[rDigits.Count];

        var j = 0;
        for (var i = rDigits.Count - 1; i >= 0; i--)
        {
            arr[j] = rDigits[i];
            j++;
        }

        return arr;
    }
}
