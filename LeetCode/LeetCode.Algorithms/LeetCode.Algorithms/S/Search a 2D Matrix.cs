namespace LeetCode.Algorithms;

public static class Search_a_2D_Matrix
{
    public static bool SearchMatrix(int[][] matrix, int target)
    {
        var flatten = matrix.SelectMany(x=> x).ToArray();
        if (BinarySearch.Search(flatten, target) >= 0)
        {
            return true;
        }
        return false;
    }
}
