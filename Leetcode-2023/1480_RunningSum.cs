using System;
namespace Leetcode_2023
{
	public static class _480_RunningSum
	{
        public static int[] RunningSum(int[] nums)
        {
            /*Input: nums = [1,2,3,4]
        Output: [1,3,6,10]
        Explanation: Running sum is obtained as follows: [1, 1+2, 1+2+3, 1+2+3+4].*/
            int[] runningsumArray = new int[nums.Length];
            int prevSum = 0;
            int counter = 0;
            foreach (int i in nums)
            {
                runningsumArray[counter] = i + prevSum;
                prevSum = runningsumArray[counter];
                counter++;
            }
            return runningsumArray;
        }
    }
}

