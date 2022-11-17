namespace LeetCode.Algorithms;

public static class ReverseInteger
{
    public static int Reverse(int x)
    {
        var isNegative = x < 0;
        try
        {
            var r = string.Join(string.Empty, Math.Abs(x).ToString().Reverse());
            if (isNegative) r = "-" + r;
            return int.Parse(r);

        }
        catch (OverflowException)
        {
            return 0;
        }

    }

}
