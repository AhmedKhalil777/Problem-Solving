namespace HackerRank.Algorithms.Tests;

public class BillDivision
{
    [Fact]
    public void bonAppetit_GivenBrianCanNotPay_ShouldPrintBonAppetit()
    {
        Algorithms.BillDivision
            .bonAppetit(new List<int>{3 ,10, 2 , 9}, 1,7);
        Algorithms.BillDivision.Result.Should().Be("Bon Appetit");
    }
    
    
    [Fact]
    public void bonAppetit_GivenBrianCanPay_ShouldPrintBrainPocketAfterPay()
    {
        Algorithms.BillDivision
            .bonAppetit(new List<int>{3, 10, 2, 9}, 1,12);
        Algorithms.BillDivision.Result.Should().Be("5");
    }
}