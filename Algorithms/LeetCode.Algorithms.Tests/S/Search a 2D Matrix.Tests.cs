using Newtonsoft.Json;

namespace LeetCode.Algorithms.Tests;

public class Search_a_2D_Matrix
{

    [Fact]
    public void SearchMatrix()
    {
        var json = "[[1,3,5,7],[10,11,16,20],[23,30,34,60]]";
        var actual = JsonConvert.DeserializeObject<int[][]>(json);
        Algorithms.Search_a_2D_Matrix.SearchMatrix(actual,3).Should().BeTrue();
        //////
        json = "[[1,3,5,7],[10,11,16,20],[23,30,34,60]]";
        actual = JsonConvert.DeserializeObject<int[][]>(json);
        Algorithms.Search_a_2D_Matrix.SearchMatrix(actual, 13).Should().BeFalse();

    }
}
