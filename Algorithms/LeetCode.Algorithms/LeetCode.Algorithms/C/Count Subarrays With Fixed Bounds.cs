namespace LeetCode.Algorithms;

public class Count_Subarrays_With_Fixed_Bounds
{
    List<Tuple<int, int>> ValidSubarrays = new ();

    public long CountSubarraysII(int[] nums, int minK, int maxK)
    {
        // initialize some variables
        var n = nums.Length;
        var leftBound = -1;
        var lastMin = -1;
        var lastMax = -1; 
        var count = 0L;
        
        for (int i = 0; i < n; i++) {
            // check if nums[i] is within the range [minK, maxK]
            if (nums[i] >= minK && nums[i] <= maxK) {
                // if nums[i] is equal to minK, update lastMin to the current index i
                lastMin = (nums[i] == minK) ? i : lastMin;
                // if nums[i] is equal to maxK, update lastMax to the current index i
                lastMax = (nums[i] == maxK) ? i : lastMax;
                // update the count by the number of valid subarrays between leftBound and the 
                // smaller of lastMin and lastMax
                count += Math.Max(0, Math.Min(lastMin, lastMax) - leftBound);
            } else {
                // if nums[i] is not within the range [minK, maxK], update leftBound to i
                leftBound = i;
                // reset lastMin and lastMax to -1
                lastMin = -1;
                lastMax = -1;
            }
        }
        
        // return the final count of valid subarrays
        return count;
    }

    public long CountSubarrays(int[] nums, int minK, int maxK)
    {
        var mins = new List<int>();
        var maxs = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (minK == nums[i])
            {
                mins.Add(i);
            }

            if (maxK == nums[i])
            {
                maxs.Add(i);
            }
        }

        foreach (var min in mins)
        {
            foreach (var max in maxs)
            {
                ValidateSubArray(nums, min, max,minK ,maxK);
            }
        }

        return ValidSubarrays.Count;
    }


    public void ValidateSubArray(int[] nums, int min , int max, int minK, int maxK)
    {
        var isValidSubaraay = false;
        if (min > max)
        {
           isValidSubaraay =  IsValidSubarray(nums.Skip(max).Take(min - max), minK, maxK);
           if (!isValidSubaraay)
           {
               return;
           }

           if (!ValidSubarrays.Any(x=> (x.Item1 == min && x.Item2 == max) || (x.Item1 == max && x.Item2 == min) ))
           {
               ValidSubarrays.Add(new Tuple<int, int>(min, max));
           }
           while (max> 0)
           {
               max--;
               if (nums[max] > maxK || nums[max] < minK)
               {
                   break;
               }
               if (!ValidSubarrays.Any(x=> (x.Item1 == min && x.Item2 == max) || (x.Item1 == max && x.Item2 == min)))
               {
                   ValidSubarrays.Add(new Tuple<int, int>(min, max));
               }
           }
           
           while (min < nums.Length -1)
           {
               min++;
               if (nums[min] > maxK || nums[min] < minK)
               {
                   break;
               }
               if (!ValidSubarrays.Any(x=> (x.Item1 == min && x.Item2 == max) || (x.Item1 == max && x.Item2 == min)))
               {
                   ValidSubarrays.Add(new Tuple<int, int>(min, max));
               }
           }


        }
        else if(max > min)
        {
            isValidSubaraay =  IsValidSubarray(nums.Skip(min).Take(max - min), minK, maxK);
            if (!isValidSubaraay)
            {
                return;
            }
            if (!ValidSubarrays.Any(x=> (x.Item1 == min && x.Item2 == max) || (x.Item1 == max && x.Item2 == min) ))
            {
                ValidSubarrays.Add(new Tuple<int, int>(min, max));
            }
            while (min> 0)
            {
                min--;
                if (nums[min] > maxK || nums[min] < minK)
                {
                    break;
                }
                if (!ValidSubarrays.Any(x=> (x.Item1 == min && x.Item2 == max) || (x.Item1 == max && x.Item2 == min)))
                {
                    ValidSubarrays.Add(new Tuple<int, int>(min, max));
                }
            }
           
            while (max < nums.Length -1)
            {
                max++;
                if (nums[max] > maxK || nums[max] < minK)
                {
                    break;
                }
                if (!ValidSubarrays.Any(x=> (x.Item1 == min && x.Item2 == max) || (x.Item1 == max && x.Item2 == min)))
                {
                    ValidSubarrays.Add(new Tuple<int, int>(min, max));
                }
            }
        }
        else
        {
            if (!ValidSubarrays.Any(x=> x.Item1 == min && x.Item2 == min))
            {
                ValidSubarrays.Add(new Tuple<int, int>(min, min));
            }
        }
        
    }

    public bool IsValidSubarray(IEnumerable<int> nums, int minK, int maxK)
    {
        return nums.All(x => x <= maxK && x >= minK);
    }
}