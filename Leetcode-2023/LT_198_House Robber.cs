using System;
namespace Leetcode_2023
{
	public class LT_198_House_Robber
	{
		public LT_198_House_Robber()
		{
		}
        public int Rob(int[] nums)
        {
			if (nums.Length == 0)
				return 0;
			int prev1, prev2, temp;
			prev1 = prev2 = 0;
			for(int n=0;n<nums.Length;n++)
			{
				temp = prev1;
                prev1 = Math.Max(prev2 + nums[n], prev1);
				prev2 = temp;
			}
			return prev1;
        }
    }
}

