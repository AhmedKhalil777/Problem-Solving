using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Tests;

public class ACM_ICPC_Team
{
    [Theory]
    [InlineData("""["10101", "11100", "11010", "00101"]""", "[5,2]" )]
    public void acmTeam(string jsonInput, string jsonOuput)
    {
        var input = JsonSerializer.Deserialize<List<string>>(jsonInput);
        var res = Algorithms.ACM_ICPC_Team.acmTeam(input);
        JsonSerializer.Serialize(res).Should().Be(jsonOuput);
    }

}
