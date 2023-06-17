using System;
namespace Leetcode_2023
{
	public class LT_15_3Sum
	{
		public LT_15_3Sum()
		{
		}
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
			int start=0, left, right, target=0;
			int n = nums.Length;
			if (n <= 2)
				return result;
			Array.Sort(nums);
			while (start < n - 2)
			{
				left = start + 1;
				right = n - 1;
				target = nums[start] * -1;
				while (left < right)
				{
					if (nums[left] + nums[right] < target)
						left++;
					else if (nums[left] + nums[right] > target)
						right--;
					else
					{
						List<int> oneSol = new List<int> {nums[start],nums[left],nums[right] };
						result.Add(oneSol);
						while (left < right && nums[left] == oneSol[1])
							left++;
                        while (left < right && nums[right] == oneSol[2])
                            right--;
                    }
                }
				int currStart = nums[start];
				while (start < n - 2 && nums[start] == currStart)
					start++;
            }
			return result;
        }
    }
}

