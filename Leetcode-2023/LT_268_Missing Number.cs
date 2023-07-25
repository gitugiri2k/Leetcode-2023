using System;
namespace Leetcode_2023
{
	public class LT_268_Missing_Number
	{
		public LT_268_Missing_Number()
		{
		}
        public int MissingNumber(int[] nums)
        {
			int sumOfAll = 0;
			int sumofCurrentArray = 0;
			for (int i = 0; i < nums.Length; i++)
				sumofCurrentArray += nums[i];
            //for (int i = 0; i < nums.Length+1; i++)
            //    sumOfAll += i;
            //sum of first n int = n(n+1)/2
            sumOfAll=nums.Length * (nums.Length + 1) / 2;
			return sumOfAll - sumofCurrentArray;
        }
    }
}

