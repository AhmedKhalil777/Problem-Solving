using System.Diagnostics;

using Xunit.Abstractions;
using Xunit.Sdk;

namespace HackerRank.Algorithms.Tests;
public class SaveThePrisoner
{
    public SaveThePrisoner(ITestOutputHelper helper)
    {
        this.helper = helper;
    }
    [Fact]
    public void SaveThePrisoner_GivenMultiSets_ShouldReturnExpected()
    {
        Algorithms.SaveThePrisoner.saveThePrisoner(5, 2,  1).Should().Be(2);
        Algorithms.SaveThePrisoner.saveThePrisoner(5, 2, 2).Should().Be(3);
        Algorithms.SaveThePrisoner.saveThePrisoner(7, 19, 2).Should().Be(6);
        Algorithms.SaveThePrisoner.saveThePrisoner(3, 7, 3).Should().Be(3);

    }

    [Fact]
    public void SaveThePrisoner_GivenBatchSets_ShouldReturnExpected()
    {
        var i = 0;
        "./S/SaveThePrisonersBatch.txt".ReadLinesAsMatrix().ToList().ForEach(x =>
        {
            var res = Algorithms.SaveThePrisoner.saveThePrisoner(x[0], x[1], x[2]);
            this.helper.WriteLine("{0} - {1}  - {2} - {3} - {4} == {5}", i, x[0], x[1], x[2], BatchRes[i], res);
            res.Should().Be(BatchRes[i++]);
        });

    }


    static List<int> BatchRes = new List<int>
    {
        20809        ,
15                   ,
436776010            ,
999983943            ,
30                   ,
17                   ,
2                    ,
871077787            ,
1                    ,
275329482            ,
999999998            ,
95                   ,
999999998            ,
22                   ,
378                  ,
4                    ,
468840391            ,
29010                ,
1                    ,
5                    ,
38                   ,
120                  ,
67                   ,
3                    ,
1717786              ,
69                   ,
12                   ,
514824323            ,
178                  ,
1                    ,
152                  ,
999974359            ,
18                   ,
5                    ,
195446093            ,
54691                ,
100                  ,
133                  ,
1                    ,
2                    ,
689370114            ,
22721112             ,
9                    ,
180                  ,
78                   ,
20311                ,
16                   ,
70866971             ,
269208525            ,
107                  ,
14                   ,
50150967             ,
4                    ,
144                  ,
2985                 ,
990271854            ,
27888                ,
1                    ,
396                  ,
6                    ,
5                    ,
5                    ,
4                    ,
999999998            ,
38386279             ,
16                   ,
198                  ,
999999997            ,
9                    ,
1946080              ,
999967088            ,
6922                 ,
206648315            ,
1                    ,
1                    ,
114                  ,
11                   ,
148                  ,
999997152            ,
90143094             ,
1                    ,
123                  ,
640282836            ,
999999998            ,
999999998            ,
11130                ,
11                   ,
999999999            ,
26                   ,
40                   ,
54                   ,
6                    ,
183                  ,
8                    ,
583101930            ,
999999997            ,
1                    ,
328966241            ,
36
    };
    private readonly ITestOutputHelper helper;
}
