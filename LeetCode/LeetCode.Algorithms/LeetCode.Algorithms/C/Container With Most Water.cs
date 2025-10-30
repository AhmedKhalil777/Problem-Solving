namespace LeetCode.Algorithms;

public class Container_With_Most_Water
{
    public int MaxArea(int[] height) {
        if (!height.Any() || height.Length == 1)
        {
            return 0;
        }

        var max = 0;
        for (int i = 0, j = height.Length -1 ; i < j;)
        {
            if (height[i] > height[j])
            {
                var curr = (j - i) * height[j];
                max = Math.Max(max, curr);
                j--;
            }
            else
            {
                var curr = (j - i) * height[i];
                max = Math.Max(max, curr);
                i++;
            }
        }

        return max;
    }
}