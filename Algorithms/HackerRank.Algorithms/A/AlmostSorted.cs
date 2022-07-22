namespace HackerRank.Algorithms;

public static class AlmostSorted
{
    public static string IsSorted { get; set; }
    public static string? Sorting { get; set; }
    public static void almostSorted(List<int> arr)
    {
        int count=0;
        int u=0,v=0;
        
        // If count = 1 or 2 => can be swappable
        // If count > 1 => can be reversible
        for (int i = 1; i < arr.Count; i++)
        {
            if (arr[i - 1] <= arr[i]) continue;
            ++count;
            if (u == 0)
            {
                u=i;
            }
            v=i;
        }

        switch (count)
        {
            // Can be swapped
            case 1:
                switch (arr.Count)
                {
                    case > 2 when arr[u - 1] < arr[v + 1] && arr[v] > arr[u - 2 >= 0 ? u - 2 : 0]:
                    case 2:
                        Console.WriteLine("yes\nswap "+u+" "+(v+1));
                        IsSorted = "yes";
                        Sorting = "swap " + u + " " + (v + 1);
                        break;
                    default:
                        Console.WriteLine("no");
                        IsSorted = "no";
                        break;
                }

                break;
            //  swappable
            case 2:
                Console.WriteLine("yes\nswap "+u+" "+(v+1));
                IsSorted = "yes";
                Sorting = "swap " + u + " " + (v + 1);
                break;
            // Reversible
            case > 1 when arr[u - 2] < arr[v] && arr[u - 1] < arr[v + 1] && v - u == count - 1:
                Console.WriteLine("yes\nreverse "+u+" "+(v+1));
                IsSorted = "yes";
                Sorting = "reverse " + u + " " + (v + 1);
                break;
            // not reversible not swappable
            case > 1:
                Console.WriteLine("no");
                IsSorted = "no";
                break;
            // Already sorted
            case 0:
                Console.WriteLine("yes");
                IsSorted = "yes";
                break;
        }
    }
    
    
    
    
    
}