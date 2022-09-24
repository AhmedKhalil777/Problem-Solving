namespace HackerRank.Algorithms;

public static class JumpingOnClouds
{
    // Complete the jumpingOnClouds function below.
    public static int jumpingOnClouds(int[] c, int k)
    {
        int e = 100, jump = 0;
        while (true)
        {
            e--;
            if (c[jump] == 1) e -= 2;
            jump = (jump + k) % c.Length;
            if (jump == 0) break;
        }
        return e;

    }

}
