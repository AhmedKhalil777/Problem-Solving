namespace HackerRank.Algorithms;

public static class NumberLineJumps
{
    public static string kangaroo(int x1, int v1, int x2, int v2)
    {
        bool _isNotSkipped = true;
        while (_isNotSkipped)
        {
            if (x1== x2)
            {
                return "YES";
            }
            _isNotSkipped = !(v1 >= v2 && x1 > x2 || v2 >= v1 && x2 > x1);
            x1 += v1;
            x2 += v2;
        }

        return "NO";
    }
}