namespace LeetCode.Algorithms;

public class Lowest_Common_Ancestor_of_a_Binary_Search_Tree
{
    public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        if (root.val > p.val && root.val > q.val) return LowestCommonAncestor(root.left, p, q);
        else if (root.val < p.val && root.val < q.val) return LowestCommonAncestor(root.right, p, q);
        else return root;
    }
}
