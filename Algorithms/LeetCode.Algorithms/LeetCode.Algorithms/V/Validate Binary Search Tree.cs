using System;

namespace LeetCode.Algorithms;

public static class Validate_Binary_Search_Tree
{
    /// <summary>
    /// Using BST PreOrder Traverse to check
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public static bool IsValidBST(TreeNode root)
    {
        return Validate(root, null, null);
    }

    public static bool Validate(TreeNode root, int? low, int? high)
    {
        if (root == null)
        {
            return true;
        }
        if ((low != null && root.val <= low) || (high != null && root.val >= high))
        {
            return false;
        }
        return Validate(root.right, root.val, high) && Validate(root.left, low, root.val);
    }

}
