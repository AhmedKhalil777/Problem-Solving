namespace HackerRank.Algorithms.Tests;

public class FormingAMagicSquare
{
    [Fact]
    public void formingMagicSquare_GivenNonMagicSquare_ShouldReturnTotalChanges()
    {
        Algorithms.FormingAMagicSquare.formingMagicSquare(new List<List<int>>
        {
            new() { 5, 3, 4 },
            new() { 1, 5, 8 },
            new() { 6, 4, 2 },
        }).Should().Be(7);
    }
    
}