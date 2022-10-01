namespace HackerRank.Algorithms.Tests;

public class LibraryFine
{
    [Fact]
    public void LibraryFine_GivenMultiSetOfDates_ShouldReturnExpectedFines()
    {
        Algorithms.LibraryFine.libraryFine(d1: 9, m1: 6, y1: 2015, d2: 6, m2: 6, y2: 2015).Should().Be(45);
        Algorithms.LibraryFine.libraryFine(d1: 14, m1: 7, y1: 2018, d2: 5, m2: 7, y2: 2018).Should().Be(135);
        Algorithms.LibraryFine.libraryFine(d1: 2, m1: 7, y1: 1014, d2: 1, m2: 1, y2: 1014).Should().Be(3000);
    }
}
