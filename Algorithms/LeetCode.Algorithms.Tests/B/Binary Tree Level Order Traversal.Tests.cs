using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Tests;

[UsesVerify]
public class Binary_Tree_Level_Order_Traversal
{
    [Fact]
    public async Task LevelOrder()
    {
        var node = new TreeNode(3,
            new TreeNode(9), 
            new TreeNode(20, new TreeNode(15), new TreeNode(7))
            );
       await Verify(Algorithms.Binary_Tree_Level_Order_Traversal.LevelOrder(node));
    }
}
