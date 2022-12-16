
namespace LeetCode.Algorithms.Tests;

public class NearestExitfromEntranceinMaze
{
    [Fact]
    public void NearestExitTest1()
    {
        var maze = new char[3][]; //{ { '+', '+', '.', '+' }, { '.', '.', '.', '+' }, { '+', '+', '+', '.' } };
        maze[0] = new[] { '+', '+', '.', '+' };
        maze[1] = new[] {  '.', '.', '.', '+'  };
        maze[2] = new[] { '+', '+', '+', '.' };
        Algorithms.NearestExitfromEntranceinMaze.NearestExit(maze, new[] { 1, 2 })
            .Should().Be(1);
    }

    [Fact]
    public void NearestExitTest2()
    {
        var maze = new char[3][]; 
        maze[0] = new[] { '+', '+', '+' };
        maze[1] = new[] { '.', '.', '.' };
        maze[2] = new[] { '+', '+', '+' };
        Algorithms.NearestExitfromEntranceinMaze.NearestExit(maze, new[] { 1, 0 })
            .Should().Be(2);
    }

    [Fact]
    public void NearestExitTest3()
    {
        var maze = new char[1][];
        maze[0] = new[] { '.', '+',  };

        Algorithms.NearestExitfromEntranceinMaze.NearestExit(maze, new[] { 0, 0 })
            .Should().Be(-1);
    }
}

