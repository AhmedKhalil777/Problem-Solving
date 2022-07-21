namespace HackerRank.Algorithms.Tests;

public class SubarrayDivision
{
    [Fact]
    public void birthday_GivenChocolateBarsAndBirth_ShouldReturnExpectedPossibilities1()
    {
        Algorithms.SubarrayDivision.birthday(new List<int> { 1, 2, 1, 3, 2 }, 3, 2)
            .Should().Be(2);
    }
    
    [Fact]
    public void birthday_GivenChocolateBarsAndBirth_ShouldReturnExpectedPossibilities2()
    {
        Algorithms.SubarrayDivision.birthday(new List<int> { 1 ,1, 1, 1 ,1, 1 }, 3, 2)
            .Should().Be(0);
    }
}