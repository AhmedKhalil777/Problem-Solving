namespace LeetCode.Algorithms;

public static class N_aryTreePreorderTraversal
{

    /// <summary>
    /// Depth First Search N-Tree
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public static IList<int> Preorder(Node root)
    {
        var res = new List<int>();
        PreOrderTraverse(root, res);
        return res;
    }

    public static void PreOrderTraverse(Node root, IList<int> list)
    {
        if (root == null)
        {
            return;
        }
        list.Add(root.val);
        for (int i = 0; i < root?.children?.Count ; i++)
        {
            PreOrderTraverse(root.children[i], list);
        }
    }


}
