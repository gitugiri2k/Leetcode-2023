using System;
namespace Leetcode_2023
{
	public class LT_1_Two_Sum
	{
		public LT_1_Two_Sum()
		{
		}
		public int[] TwoSum(int[] nums, int target)
		{
			/*Input: nums = [2,7,11,15], target = 9
			Output: [0,1]
			Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
			 */
			Dictionary<int, int> seen = new Dictionary<int, int>();
			int remaining = 0;
			for (int i = 0; i < nums.Length; i++)
			{
				if (!seen.ContainsKey(nums[i]))
				seen.Add(nums[i], i);
				remaining = target - nums[i];
				if (seen.ContainsKey(remaining) && seen[remaining]!=i)
				{
					return (new int[] { i, seen[remaining] });
				}
            }
			return new int[0];
		}
	}
}

