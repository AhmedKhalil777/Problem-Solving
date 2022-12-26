namespace LeetCode.Algorithms;

public static class SquaresofaSortedArray
{
    public static int[] SortedSquares(int[] nums)
    {
        return nums.Select(x => x * x ).OrderBy(x=> x).ToArray();
    }
}
