using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Tests;

public class Single_Threaded_CPU
{
    [Fact]
    public void GetOrder()
    {
        var actual = new int[4][];
        actual[0] = new int[] {1,2 };
        actual[1] = new int[] {2,4 };
        actual[2] = new int[] {3,2 };
        actual[3] = new int[] {4,1 };
        Algorithms.Single_Threaded_CPU.GetOrder(actual)
            .Should().Equal(new int[] { 0, 2, 3, 1 });
    }

    [Fact]
    public void GetOrder1()
    {
        var actual = new int[5][];
        actual[0] = new int[] { 7, 10 };
        actual[1] = new int[] { 7, 12 };
        actual[2] = new int[] { 7, 5 };
        actual[3] = new int[] { 7, 4 };
        actual[4] = new int[] { 7, 2 };
        Algorithms.Single_Threaded_CPU.GetOrder(actual)
            .Should().Equal(new int[] {4,3,2, 0,1 });
    }

    [Fact]
    public void GetOrder2()
    {
        var json = "[[19,13],[16,9],[21,10],[32,25],[37,4],[49,24],[2,15],[38,41],[37,34],[33,6],[45,4],[18,18],[46,39],[12,24]]";
        var actual = JsonSerializer.Deserialize<int[][]>(json);
        Algorithms.Single_Threaded_CPU.GetOrder(actual)
            .Should().Equal(new int[] { 6, 1, 2, 9, 4, 10, 0, 11, 5, 13, 3, 8, 12, 7 });
    }
}
