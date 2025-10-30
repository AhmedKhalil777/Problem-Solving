using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algorithms.Tests;

[UsesVerify]
public class N_aryTreePreorderTraversal
{
    [Fact]
    public async Task Preorder()
    {
        var node = new Node(1,
            new List<Node> { 
                new Node(3, new List<Node> { new Node(5), new Node (6)}),
                new Node(2),
                new Node(4)
            });

        await Verify(Algorithms.N_aryTreePreorderTraversal.Preorder(node));
    }
}
