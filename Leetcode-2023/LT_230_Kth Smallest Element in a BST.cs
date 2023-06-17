using System;
namespace Leetcode_2023
{
    public class LT_230_Kth_Smallest_Element_in_a_BST
    {
        public LT_230_Kth_Smallest_Element_in_a_BST()
        {
        }
        static int count = 0;
        static int num = 0;
        public int KthSmallest(TreeNode root, int k)
        {
            count = k;
            traverseBSTInorder(root);
            return num;
        }
        public void traverseBSTInorder(TreeNode root)
        {
            if (root.left is not null)
                traverseBSTInorder(root.left);
            count -= 1;
            if (count == 0)
            {
                num = root.val;
                return;
            }
            if (root.right is not null)
                traverseBSTInorder(root.right);
        }
    }
}

