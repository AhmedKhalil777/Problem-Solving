
using FluentAssertions;

namespace HackerRank.DataStructures.Tests;

public class DynamicArray
{
    [Fact]
    public void dynamicArray_GivenQueries_ShouldReturnResultsOfQueries()
    {
        DataStructures.DynamicArray.dynamicArray(2, "./D/DynamicQueries1.txt".ReadLinesAsMatrix())
            .Should().Equal(new List<int> {7,3 } );
        
        DataStructures.DynamicArray.dynamicArray(1000, "./D/DynamicQueries2.txt".ReadLinesAsMatrix())
            .Should().Equal("./D/DynamicQueries2Results.txt".ReadLinesAsVector());
    }
}