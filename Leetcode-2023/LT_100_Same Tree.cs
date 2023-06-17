using System;
namespace Leetcode_2023
{
    public class LT_100_Same_Tree
    {
        public LT_100_Same_Tree()
        {

        }
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == q)
                return true;
            if (p == null || q == null)
                return false;
            if (p.val != q.val)
            {
                return false;
            }
            if (IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right))
                return true;
            return false;
        }
    }
}

