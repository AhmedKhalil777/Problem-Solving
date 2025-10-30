namespace LeetCode.Algorithms;

public static class RemoveStonestoMinimizetheTotal
{
    public static int MinStoneSum(int[] piles, int k)
    {
        var queue = new PriorityQueue<int, int>();
        for (int i = 0; i < piles.Length; i++)
        {
            queue.Enqueue(piles[i], -piles[i]);
        }

        for (int i = 0; i < k; i++)
        {
            var s = queue.Dequeue();
            s -=(int) Math.Floor((decimal)s / 2);
            queue.Enqueue(s, -s);
        }
        var sum = 0;
        while(queue.TryDequeue(out int value, out int pri))
        {
            sum += value;
        }
        return sum;
    }
}
