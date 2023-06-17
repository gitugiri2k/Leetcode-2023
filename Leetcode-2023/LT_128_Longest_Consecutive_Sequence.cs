using System;
namespace Leetcode_2023
{
    public class LT_128_Longest_Consecutive_Sequence
    {
        public LT_128_Longest_Consecutive_Sequence()
        {
        }
        //        Input: nums = [201,202,200,1,3,2]
        //[1,2,3,4,200,201,202]
        //consec=[4,3]
        //0,3,7,2,5,8,4,6,0,1
        //0,0,1,2,3,4,5,6,7,8
        //1,2,0,1
        //0,1,1,2
        //
        //        Output: 4
        //Explanation: The longest consecutive elements sequence is [1, 2, 3, 4]. Therefore its length is 4.
        public int LongestConsecutive(int[] nums)
        {
            Array.Sort(nums);
            int[] result = new int[nums.Length];
            if (nums.Length > 0)
            {
                for (int i = 0, j = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i + 1] == nums[i] + 1)
                        result[j] += 1;
                    else if (nums[i + 1] == nums[i])
                        continue;
                    else
                        j++;
                }

                result = (from r in result orderby r descending select r).ToArray();
                return (result[0] + 1);
            }
            return 0;
        }
    }
}

