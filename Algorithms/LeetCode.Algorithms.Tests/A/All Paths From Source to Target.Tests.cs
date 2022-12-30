using Newtonsoft.Json;

namespace LeetCode.Algorithms.Tests;

[UsesVerify]
public class All_Paths_From_Source_to_Target
{
    [Theory]
    [InlineData("[[1,2],[3],[3],[]]", "Test1")]
    [InlineData("[[4,3,1],[3,2,4],[3],[4],[]]","Test2")]
    public async Task AllPathsSourceTarget(string json, string verifierFile)
    {
        var actual = JsonConvert.DeserializeObject<int[][]>( json);
        await Verify(target: Algorithms.All_Paths_From_Source_to_Target.AllPathsSourceTarget(actual))
            .UseTextForParameters(verifierFile);
        
    }
}
