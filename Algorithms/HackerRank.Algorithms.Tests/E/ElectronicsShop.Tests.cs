namespace HackerRank.Algorithms.Tests;

public class ElectronicsShop
{
    [Fact]
    public void getMoneySpent_GivenPricesWithSuitableBudget_ShouldReturnMaxPrice()
    {
        Algorithms.ElectronicsShop.getMoneySpent(new []{3,1}, new []{5,2,8}, 10)
            .Should().Be(9);
        Algorithms.ElectronicsShop.getMoneySpent(new []{40,50,60 }, new []{5,8,12}, 58)
            .Should().Be(58);
        Algorithms.ElectronicsShop.getMoneySpent("./E/keyboards.txt".AsFileIntArray(),"./E/drives.txt".AsFileIntArray() , 374625)
            .Should().Be(374625);
    }
    
    [Fact]
    public void getMoneySpent_GivenPricesWithoutSuitableBudget_ShouldReturnMinusOne()
    {
        Algorithms.ElectronicsShop.getMoneySpent(new []{5}, new []{4}, 5)
            .Should().Be(-1);
    }
    
    
}