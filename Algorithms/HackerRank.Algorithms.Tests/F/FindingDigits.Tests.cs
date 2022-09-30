namespace HackerRank.Algorithms.Tests;

public class FindingDigits
{
    [Fact]
    public void FindDegits_GivenMultiSetOfInputs_ShouldRetunExpected()
    {
        Algorithms.FindDigits.findDigits(12).Should().Be(2);
        Algorithms.FindDigits.findDigits(1012).Should().Be(3);
    }
}
