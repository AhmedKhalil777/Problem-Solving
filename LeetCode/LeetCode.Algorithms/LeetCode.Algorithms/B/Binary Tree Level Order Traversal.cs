namespace LeetCode.Algorithms;

public static class Binary_Tree_Level_Order_Traversal
{
    public static IList<IList<int>> LevelOrder(TreeNode root)
    {
        var queue = new Queue<Tuple<TreeNode,int>>();
        var res = new List<List<int>>();
        if (root == null)
        {
            return new List<IList<int>>();
        }
        int level = 0;
        queue.Enqueue(new Tuple<TreeNode,int>(root,level));
        while (queue.Count != 0)
        {
            queue.TryDequeue(out var node);
            level = node.Item2;
            if (res.Count < level+1)
            {
                res.Add(new List<int> { node.Item1.val });
            }
            else
            {
                res[(int)level].Add(node.Item1.val);
            }

            if (node.Item1.left is not null)
            {
                queue.Enqueue(new Tuple<TreeNode, int> (node.Item1.left, level+1));
            }
            if (node.Item1.right is not null)
            {
                queue.Enqueue(new Tuple<TreeNode, int>(node.Item1.right, level + 1));
            }
        }

        var resF = new List<IList<int>>();
        for (int i = 0; i < res.Count; i++)
        {
            resF.Add(res[i]);
        }
        return resF;
    }

}
