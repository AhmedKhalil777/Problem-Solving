using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Tests;

public class JumbGame
{
    [Fact]
    public void CanJumb()
    {
        Algorithms.JumpGame.CanJump(new int[] { 2, 3, 1, 1, 4 }).Should().BeTrue();
        Algorithms.JumpGame.CanJump(new int[] { 3, 2, 1, 0, 4 }).Should().BeFalse();
        Algorithms.JumpGame.CanJump(new int[] { 2, 0, 0 }).Should().BeTrue();
    }
}
