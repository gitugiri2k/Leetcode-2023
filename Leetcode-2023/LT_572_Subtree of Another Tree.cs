using System;
namespace Leetcode_2023
{
    public class LT_572_Subtree_of_Another_Tree
    {
        public LT_572_Subtree_of_Another_Tree()
        {
        }
        public bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            if (root == null) return false;
            if (IsSameTree(root, subRoot)) return true;
            return IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
        }
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && null == q)
                return true;
            if (p == null || q == null)
                return false;
            if (p.val != q.val)
            {
                return false;
            }
            else
                return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
    }
}

