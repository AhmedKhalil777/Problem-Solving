namespace HackerRank.DataStructures;

public class LeftRotation
{
    public static List<int> rotateLeft(int d, List<int> arr)
    {
        var res = new int[arr.Count];
        for (int i = 0; i < arr.Count; i++)
        {
            var rIndex = i - d;
            if (rIndex < 0)
                rIndex  += arr.Count;
            
            res[rIndex] = arr[i];
        }
        return res.ToList();
    }
}