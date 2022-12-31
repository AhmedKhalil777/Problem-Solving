using Newtonsoft.Json;

namespace HackerRank.Algorithms.Tests;

public class Queen_s_Attack_II
{
    [Theory]
    [InlineData(5,3,4,3,"[[5, 5],[ 4,2],[2,3]]",10)]
    [InlineData(1,0,1,1,null,0)]
    [InlineData(2,0,1,1,null,3)]
    [InlineData(5,0,3,1,null,12)]
    [InlineData(4,0,4,4,null,9)]
    [InlineData(3,0,3,3,null,6)]
    [InlineData(100000, 0, 4187, 5068, null, 308369)]
    public void queensAttack(int n, int k, int x, int y, string obstacles,  int res)
    {
        var obstaclesAct = new List<List<int>>();
        if (obstacles != null)
        {
           obstaclesAct = JsonConvert.DeserializeObject<List<List<int>>>(obstacles);
        }
        Algorithms.Queen_s_Attack_II.queensAttack(n, k, x, y,obstaclesAct )
            .Should().Be(res);
    }
}
