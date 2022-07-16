namespace HackerRank.Algorithms.Tests;
public class GradingStudents
{
    [Fact]
    public void gradingStudents_GivenMultipleGrades_ShouldBeRoundedAsExpected()
    {
        var input = new List<int>
        {
            73,
            67,
            38,
            33,
        };
        
        var output = new List<int>
        {
            75,
            67,
            40,
            33,
        };

        var res = Algorithms.GradingStudents.gradingStudents(input);
        res.Should().Equal(output);
    }
}