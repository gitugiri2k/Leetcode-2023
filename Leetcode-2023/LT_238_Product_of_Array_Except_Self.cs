using System;
namespace Leetcode_2023
{
	public class LT_238_Product_of_Array_Except_Self
	{
		public LT_238_Product_of_Array_Except_Self()
		{
		}

        //Find prefix
        //1,2,3,4
        //prefix = 1,2,6,24
        //Postfix = 24,24,12,4
        //Find Postfix
        //Output[i] = prefix[i-1]*postfix[i+1]
        //4,3,2,1,2
        //Real output = 12,16,24,48,24
        //prefix = 4,12,24,24,48
        //postfix =48,12,4,2,2
        //output = 4,1,1,1,24

        //Intuition approach -
        public int[] ProductExceptSelf(int[] nums)
        {
            //Normal Approach
            int n = nums.Length;
            int[] result = new int[n];
            int[] prefix = new int[n];
            int[] postfix = new int[n];
            prefix[0] = nums[0];
            postfix[n - 1] = nums[n - 1];
            for (int i = 1, j = n - 2; i < n; i++, j--)
            {
                prefix[i] = prefix[i - 1] * nums[i];
                postfix[j] = postfix[j + 1] * nums[j];
            }
            result[0] = 1 * postfix[1];
            result[n - 1] = 1 * prefix[n - 2];
            for (int i = 1; i < n - 1; i++)
            {
                result[i] = prefix[i - 1] * postfix[i + 1];
            }
            return result;

            //Space Optimised

        }

    }
}

