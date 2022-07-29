namespace HackerRank.DataStructures;

public class ArrayManipulation
{
    
    public static long arrayManipulation(int n, List<List<int>> queries)
    {
        long [] array = new long[n + 1];
        var m = queries.Count;
        while (m-- > 0)
        {
            array[queries[m][0] - 1] += queries[m][2];
            array[queries[m][1]] -= queries[m][2];
        }

        long sum = 0;
        long max = 0;

        for (int i = 0; i < n; i++)
        {
            sum += array[i];
            max = max > sum ? max : sum;
        }

        return max;
    }
    
    public static long arrayManipulation1(int n, List<List<int>> queries)
    { 
        var res = new long[n];
        foreach (var query in queries)
        {
            var k = query[2];
            for (var i = query[0]; i <= query[1]; i++)
            {
                res[i - 1] += k;
            }
        }
        return res.Max();
    }
    
    public static long arrayManipulation3(int n, List<List<int>> queries)
    {
        long [] array = new long[n + 1];
        var m = queries.Count;
        while (m-- > 0)
        {
            array[queries[m][0] - 1] += queries[m][2];
            array[queries[m][1]] -= queries[m][2];
        }

        long sum = 0;
        long max = 0;

        for (int i = 0; i < n; i++)
        {
            sum += array[i];
            max = max > sum ? max : sum;
        }

        return max;
    }
    
    public static long arrayManipulation2(int n, List<List<int>> queries)
    {
        long max = 0;
        var res = new long[n];
        foreach (var query in queries)
        {
            var k = query[2];
            for (var i = query[0]; i <= query[1]; i++)
            {
                res[i - 1] += k;
                if (res[i - 1] > max)
                {
                    max = res[i - 1];
                }
            }
        }
        return max;
    }
}