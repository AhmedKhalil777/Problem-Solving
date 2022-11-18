namespace LeetCode.Algorithms;

public static class RotateImage
{
    public static int[][] Rotate(int[][] matrix)
    {
        var cMatrix = matrix.Select(x=>x.ToList()).ToList();
        for (int i = 0 ; i < matrix.Length; i++)
        { 
            for (int j = 0; j < matrix.Length  ; j++)
            {
                matrix[i][j] = cMatrix[j][i];
            }
        }
        cMatrix = matrix.Select(x => x.ToList()).ToList();
        for (int i = 0, m= matrix.Length -1; i < matrix.Length; i++, m--)
        {
            for (int j = 0; j < matrix.Length; j++)
            {
                matrix[j][i] = cMatrix[j][m];
            }
        }
        return matrix;
    }
}
