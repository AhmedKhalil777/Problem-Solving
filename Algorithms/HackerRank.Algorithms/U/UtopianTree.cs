namespace HackerRank.Algorithms;

public class UtopianTree
{
    public static int utopianTree(int n)
    {
        var height = 1;
        for (var i = 1; i <= n; i++)
        {
            if (i % 2 == 1)
            {
                height += height;
                continue;
            }
            height++;
        }
        return height;
    }

}