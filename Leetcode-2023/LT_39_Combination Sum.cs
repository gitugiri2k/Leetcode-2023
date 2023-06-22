using System;
namespace Leetcode_2023
{
    public class LT_39_Combination_Sum
    {
        public LT_39_Combination_Sum()
        {
        }
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            List<IList<int>> res = new List<IList<int>>();
            return dfs(0, new Stack<int>(), 0, res, target, candidates);
        }
        public IList<IList<int>> dfs(int i, Stack<int> curr, int total, IList<IList<int>> res, int target, int[] candidates)
        {
            if (total == target)
            {
                res.Add(curr.ToArray());
                return res;
            }
            if (i >= candidates.Length || total > target)
                return res;
            curr.Push(candidates[i]);
            dfs(i, curr, total + candidates[i], res, target, candidates);
            curr.Pop();
            dfs(i+1, curr, total, res, target, candidates);
            return res;
        }
    }
}