using BenchmarkDotNet.Attributes;
using HackerRank.Utilities;

namespace HackerRank.DataStructures.Benchmarks;
// The first and second one will work fine at the small ranges of query 
// The difference will be if there are many queries with big ranges => 3 will be fast. as its case = (2 * n ) => O(n)

// The Third one work on the fact of every item in range will be sum to k, and after this range when [b+1] It will lose that progress
// So the fact is if we sum in progress whe sum on arr[a -1] and subtract the k from arr[b] as It will lose If it reach the lossy point 
// It will be the real sum in this place
public class ArrayManipulations
{
    
    [ParamsSource(nameof(ValuesForQueries))]
    public  List<List<int>> _benchMarkData;

    public static IEnumerable<List<List<int>>> ValuesForQueries() => new[]
    {
        "./A/arrayManipulations1.txt".ReadLinesAsMatrix(),
        //"./A/arrayManipulations2.txt".ReadLinesAsMatrix(), // The Worst Case
        
    };
    

    [Benchmark]
    //O(n ^ 2)
    public void ArrayMainpulation1()
    {
        DataStructures.ArrayManipulation.arrayManipulation1(10000000, _benchMarkData );
    }
    
    [Benchmark]
    //O(n ^ 2)
    public void ArrayMainpulation2()
    {
        DataStructures.ArrayManipulation.arrayManipulation2(10000000, _benchMarkData);
    }
    
    [Benchmark]
    // O(n)
    public void ArrayMainpulation3()
    {
        DataStructures.ArrayManipulation.arrayManipulation3(10000000, _benchMarkData);
    }
}