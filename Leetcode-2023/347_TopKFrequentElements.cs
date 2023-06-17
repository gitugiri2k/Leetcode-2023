using System;
namespace Leetcode_2023
{
    public class _47_TopKFrequentElements
    {
        public _47_TopKFrequentElements()
        {
        }
        public int[] TopKFrequent(int[] nums, int k)
        {
            //Input: nums = [1, 1, 1, 2, 2, 3], k = 2
            //Output: [1,2]

            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]] += 1;
                }
                else
                {
                    dict[nums[i]] = 1;
                }
            }
            dict = dict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            int[] result = dict.Keys.Take(k).ToArray();
            return result;
        }
    }
}

