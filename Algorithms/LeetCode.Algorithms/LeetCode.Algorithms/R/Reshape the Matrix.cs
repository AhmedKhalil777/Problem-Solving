namespace LeetCode.Algorithms;

public static class Reshape_the_Matrix
{
    public static int[][] MatrixReshape(int[][] mat, int r, int c)
    {
        var xLen = mat.Length;
        var yLen = mat[0].Length;
        if (xLen * yLen != r * c)
        {
            return mat;
        }
        var res = new int[r][];
        for (int i = 0; i < r; i++)
        {
            res[i] = new int[c];
        }

        int m = 0, n = 0;
        for (int i = 0; i < xLen; i++)
        {
            for (int j = 0; j < yLen; j++)
            {
                res[m][n] = mat[i][j];
                n++;
                if (n == c)
                {
                    n = 0;
                    m++;
                }
            }
        }
        return res;

    }
}
