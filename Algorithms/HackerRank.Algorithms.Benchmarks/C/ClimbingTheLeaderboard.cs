using BenchmarkDotNet.Attributes;

namespace HackerRank.Algorithms.Benchmarks;

[RPlotExporter]
public class ClimbingTheLeaderboard
{

    [Benchmark]
    public List<int> ClimbingLeaderboardV1() => Algorithms.ClimbingTheLeaderboard
        .climbingLeaderboardV1(new List<int> { 100, 90, 90, 80 }, new List<int> { 70, 80, 105 });
    
    [Benchmark]
    public List<int> ClimbingLeaderboardV2() => Algorithms.ClimbingTheLeaderboard
        .climbingLeaderboardV2(new List<int> { 100, 90, 90, 80 }, new List<int> { 70, 80, 105 });
    
    [Benchmark]
    public List<int> ClimbingLeaderboardV3() => Algorithms.ClimbingTheLeaderboard
        .climbingLeaderboardV3(new List<int> { 100, 90, 90, 80 }, new List<int> { 70, 80, 105 });
    
 //  |                Method |       Mean |     Error |    StdDev |
 //  |---------------------- |-----------:|----------:|----------:|
 //  | ClimbingLeaderboardV1 | 1,030.6 ns | 102.30 ns | 301.63 ns |
 //  | ClimbingLeaderboardV2 |   180.4 ns |  16.47 ns |  48.56 ns |
 //  | ClimbingLeaderboardV3 |   427.7 ns |  45.96 ns | 135.5 ns  |



}