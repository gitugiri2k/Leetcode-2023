using System;
namespace Leetcode_2023
{
	public class LT_153_Find_Minimum_in_Rotated_Sorted_Array
	{
		public LT_153_Find_Minimum_in_Rotated_Sorted_Array()
		{
		}
        public int FindMin(int[] nums)
        {
			/*
			 Input: nums = [4,5,6,7,0,1,2]
Output: 0
Explanation: The original array was [0,1,2,4,5,6,7] and it was rotated 4 times.
			left = 0
			right = 7
			mid = 7+0/2=3
			mid>right
			left = mid+1

			left = 4
			right = 7
			mid=5
			mid<right
			right=mid
			 */
			int left = 0, right = nums.Length - 1;
			int mid;
			while (left < right)
			{
				mid = (left + right) / 2;
                if (nums[mid] > nums[right])
				{
					left = mid + 1;
				}
				else
				{
					right = mid;
				}
			}
			return nums[left];
        }
    }
}

