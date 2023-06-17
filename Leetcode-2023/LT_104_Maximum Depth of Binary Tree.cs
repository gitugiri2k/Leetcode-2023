using System;
namespace Leetcode_2023
{
    public class LT_104_Maximum_Depth_of_Binary_Tree
    {
        public LT_104_Maximum_Depth_of_Binary_Tree()
        {
        }
        public int MaxDepth(TreeNode root)
        {
            Queue<TreeNode> q = new Queue<TreeNode>();
            TreeNode t;
            if (root == null)
                return 0;
            q.Enqueue(root);
            int level = 0, num_node_level = 1;
            while (q.Count is not 0)
            {
                t = q.Dequeue();
                Console.WriteLine(t.val);
                if (t.left is not null)
                    q.Enqueue(t.left);
                if (t.right is not null)
                    q.Enqueue(t.right);
                num_node_level -= 1;
                if (num_node_level == 0)
                {
                    level++;
                    num_node_level = q.Count;
                }
            }
            return level;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}

