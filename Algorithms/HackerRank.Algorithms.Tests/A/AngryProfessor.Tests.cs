namespace HackerRank.Algorithms.Tests;

public class AngryProfessor
{
    [Fact]
    public void angryProfessor_GivenArrivalAttendees_ShouldReturnProfessorReply()
    {
        Algorithms.AngryProfessor.angryProfessor(3, "-1 -3 4 2".AsStringIntList()).Should().Be("YES");
        Algorithms.AngryProfessor.angryProfessor(2, "0 -1 2 1".AsStringIntList()).Should().Be("NO");
    }
}