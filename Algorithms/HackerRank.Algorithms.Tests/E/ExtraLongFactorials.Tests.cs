namespace HackerRank.Algorithms.Tests;

public class ExtraLongFactorials
{
    [Fact]
    public void ExtraLongFactorials_GivenMultiSet_ShouldReturnExpected()
    {
        Algorithms.ExtraLongFactorials.extraLongFactorials(30).Should().Be("265252859812191058636308480000000");
        Algorithms.ExtraLongFactorials.extraLongFactorials(25).Should().Be("15511210043330985984000000");
    }
}
