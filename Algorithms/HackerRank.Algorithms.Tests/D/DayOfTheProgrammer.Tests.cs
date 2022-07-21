namespace HackerRank.Algorithms.Tests;

public class DayOfTheProgrammer
{
    [Fact]
    public void dayOfProgrammer_GivenYears_ShouldReturnExpectedDates()
    {
        Algorithms.DayOfTheProgrammer.dayOfProgrammer(2017)
            .Should().Be("13.09.2017");
        Algorithms.DayOfTheProgrammer.dayOfProgrammer(2016)
            .Should().Be("12.09.2016");
        Algorithms.DayOfTheProgrammer.dayOfProgrammer(2000)
            .Should().Be("12.09.2000");
        Algorithms.DayOfTheProgrammer.dayOfProgrammer(1800)
            .Should().Be("12.09.1800");
        Algorithms.DayOfTheProgrammer.dayOfProgrammer(1918)
            .Should().Be("26.09.1918");
        Algorithms.DayOfTheProgrammer.dayOfProgrammer(2100)
            .Should().Be("13.09.2100");
        Algorithms.DayOfTheProgrammer.dayOfProgrammer(1872)
            .Should().Be("12.09.1872");
    }
    
}