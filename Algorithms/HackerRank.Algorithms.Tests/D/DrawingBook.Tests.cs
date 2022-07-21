namespace HackerRank.Algorithms.Tests;

public class DrawingBook
{
    [Fact]
    public void pageCount_GivenPageRequired_ShouldReturnNumberOfLeastTurns()
    {
        Algorithms.DrawingBook.pageCount(5,4)
            .Should().Be(0);
        
        Algorithms.DrawingBook.pageCount(6,2)
            .Should().Be(1);
        
        Algorithms.DrawingBook.pageCount(5,3)
            .Should().Be(1);
        
        Algorithms.DrawingBook.pageCount(6,5)
            .Should().Be(1);
        Algorithms.DrawingBook.pageCount(7,3)
            .Should().Be(1);
        Algorithms.DrawingBook.pageCount(6,5)
            .Should().Be(1);
        
        Algorithms.DrawingBook.pageCount(4,4)
            .Should().Be(0);
        
    }
}