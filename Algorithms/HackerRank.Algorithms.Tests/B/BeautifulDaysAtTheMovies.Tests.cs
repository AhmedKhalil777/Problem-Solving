namespace HackerRank.Algorithms.Tests;

public class BeautifulDaysAtTheMovies
{
    [Fact]
    public void ReverseNum_GivenANum_ShouldReturnReverse()
    {
        Algorithms.BeautifulDaysAtTheMovies.ReverseNum(21).Should().Be(12);
        Algorithms.BeautifulDaysAtTheMovies.ReverseNum(120).Should().Be(21);
    }
    
    [Fact]
    public void beautifulDays_GivenFirstAndLastAndK_ShouldReturnBeautifulDays()
    {
        Algorithms.BeautifulDaysAtTheMovies.beautifulDays(20 ,23, 6).Should().Be(2);
    }
}