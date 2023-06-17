using System;
namespace Leetcode_2023
{
	public class LT_235_Lowest_Common_Ancestor_of_a_Binary_Search_Tree
	{
		public LT_235_Lowest_Common_Ancestor_of_a_Binary_Search_Tree()
		{
		}
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
			if (p.val == root.val || q.val == root.val)
				return root;
			else if ((p.val < root.val && q.val > root.val) || (p.val > root.val && q.val < root.val))
				return root;
			else if (p.val > root.val && q.val > root.val)
				return LowestCommonAncestor(root.right, p, q);
			else
                return LowestCommonAncestor(root.left, p, q);
        }
    }
}

