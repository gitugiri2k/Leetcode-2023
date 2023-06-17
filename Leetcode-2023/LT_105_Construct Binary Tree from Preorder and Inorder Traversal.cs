using System;
namespace Leetcode_2023
{
	public class LT_105_Construct_Binary_Tree_from_Preorder_and_Inorder_Traversal
	{
		public LT_105_Construct_Binary_Tree_from_Preorder_and_Inorder_Traversal()
		{
		}
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
			TreeNode root = new TreeNode(preorder[0]);
			int mid = Array.IndexOf(inorder, preorder[0]);
			//Build Left subtree

        }
    }
}

