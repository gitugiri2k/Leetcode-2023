using System;
namespace Leetcode_2023
{
    public class LT_102_Binary_Tree_Level_Order_Traversal
    {
        public LT_102_Binary_Tree_Level_Order_Traversal()
        {
        }
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            if (root is null)
                return null;
            Queue<TreeNode> q = new Queue<TreeNode>();
            IList<IList<int>> resList = new List<IList<int>>();
            List<int> subList;
            q.Enqueue(root);
            TreeNode curr = new TreeNode();
            int level = 0;
            while (q.Count != 0)
            {
                subList = new List<int>();
                for (level = q.Count; level > 0; level--)
                {
                    curr = q.Dequeue();
                    subList.Add(curr.val);
                    if (curr.left is not null)
                        q.Enqueue(curr.left);
                    if (curr.right is not null)
                        q.Enqueue(curr.right);
                }
                resList.Add(subList);
            }
            return resList;
        }
    }
}

