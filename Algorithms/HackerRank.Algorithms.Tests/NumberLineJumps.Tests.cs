namespace HackerRank.Algorithms.Tests;

public class NumberLineJumps
{
    
    [Fact]
    public void kangaroo_GivenKangaroosCanNotCollision_ShouldReturnNo()
    {
        Algorithms.NumberLineJumps.kangaroo(0, 2, 5, 3).Should().Be("NO");
    }
    
    [Fact]
    public void kangaroo_GivenKangaroosCanCollision_ShouldReturnYes()
    {
        Algorithms.NumberLineJumps.kangaroo(0, 3, 4, 2).Should().Be("YES");
    }
}