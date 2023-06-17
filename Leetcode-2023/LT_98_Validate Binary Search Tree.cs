using System;
namespace Leetcode_2023
{
    public class LT_98_Validate_Binary_Search_Tree
    {
        public LT_98_Validate_Binary_Search_Tree()
        {
        }
        public bool IsValidBST(TreeNode root)
        {
            return IsValid(root, Int64.MinValue, Int64.MaxValue);
        }
        public bool IsValid(TreeNode root, long min, long max)
        {
            if (root is null)
                return true;
            if (root.val < min || root.val > max)
                return false;
            else
                return IsValid(root.left, min, root.val) && IsValid(root.right, root.val, max);
        }
}
}

