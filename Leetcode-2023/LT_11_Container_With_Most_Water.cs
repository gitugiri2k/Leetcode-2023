using System;
namespace Leetcode_2023
{
    public class LT_11_Container_With_Most_Water
    {
        public LT_11_Container_With_Most_Water()
        {
        }
        /*
		Input: height = [1,8,6,2,5,4,8,3,7]

		1	8	6	2	5	4	8	3	7
		l=0
		r=8
		area=height[l]*r=1*8=8
		
		while(numatleft < currleft)
		left++


		Output: 49
		Explanation: The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7].
		In this case, the max area of water (blue section) the container can contain is 49.
		 */
        public int MaxArea(int[] height)
        {
            int l = 0, r = height.Length - 1;
            int result = 0, temp = 0;
            while (l<r)
            {
                temp = (r - l) * Math.Min(height[l], height[r]);
                if (temp > result)
                    result = temp;
                if (height[l] <= height[r])
                {
                    l++;
                }
                r--;
            }
            return result;
        }

    }
}

