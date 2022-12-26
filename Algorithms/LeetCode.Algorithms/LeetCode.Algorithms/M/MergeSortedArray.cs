
namespace LeetCode.Algorithms;

public static class MergeSortedArray
{
    public static int[] Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var j = 0; 
        var k = 0;
        var nums3 = new int[nums1.Length];
        nums1.CopyTo(nums3, 0);
        for (int i = 0; i < n+m; i++)
        {

            if (j >= m  )
            {
                nums1[i] = nums2[k];
                k++;
                continue;
            }

            if (k >= n  )
            {
                nums1[i] = nums3[j];
                j++;
                continue;
            }

            if (nums3[j] > nums2[k])
            {
                nums1[i] = nums2[k];
                k++;
                continue;
            }

            if (nums3[j] < nums2[k])
            {
                nums1[i] = nums3[j];
                j++;
                continue;
            }

            if (nums3[j] == nums2[k])
            {
                nums1[i++] = nums3[j++];
                nums1[i] = nums2[k++];

            }
        }
        return nums1;
    }
}
