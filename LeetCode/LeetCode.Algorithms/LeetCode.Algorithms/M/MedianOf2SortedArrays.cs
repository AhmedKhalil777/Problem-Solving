namespace LeetCode.Algorithms;

public class MedianOf2SortedArrays
{

    public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        var merge = nums1.ToList();
        merge.AddRange(nums2);
        if (merge.Count % 2 == 0)
        {
            var res = merge.OrderBy(x => x).Skip((merge.Count / 2) - 1).Take(2);
            return res.Average();
        }
        return merge.OrderBy(x => x).Skip((merge.Count / 2)).First();

    }
}
