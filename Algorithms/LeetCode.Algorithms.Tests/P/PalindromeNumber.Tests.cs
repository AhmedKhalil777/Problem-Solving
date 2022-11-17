namespace LeetCode.Algorithms.Tests;

public class PalindromeNumber
{
    [Fact]
    public void IsPlaindrome_GivenMultiSet_ShouldReturnExpected()
    {
        Algorithms.PalindromeNumber.IsPalindrome(121)
            .Should().BeTrue();


    }
}
