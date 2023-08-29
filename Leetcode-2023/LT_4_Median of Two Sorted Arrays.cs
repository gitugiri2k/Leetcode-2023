using System;
namespace Leetcode_2023
{
	public class LT_4_Median_of_Two_Sorted_Arrays
	{
		public LT_4_Median_of_Two_Sorted_Arrays()
		{
            
        }
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int needed = 0;
            int n1 = nums1.Length;
            int n2 = nums2.Length;
            if ((n1 + n2) % 2 == 0)
            {
                needed = ((n1 + n2) / 2) + 1;
            }
            else
            {
                needed = (n1 + n2 + 1) / 2;
            }
            Console.WriteLine($"needed ={needed}");
            int[] nums3 = new int[needed];
            int p1 = 0, p2 = 0, p3 = 0;
            while (p3 < needed)
            {
                if (p1 < n1 && p2 < n2)
                {
                    if (nums1[p1] < nums2[p2])
                    {
                        nums3[p3] = nums1[p1];
                        p1++;
                    }
                    else
                    {
                        nums3[p3] = nums2[p2];
                        p2++;
                    }
                }
                else if (p1 >= n1 - 1 && p2 < n2)
                {
                    nums3[p3] = nums2[p2];
                    p2++;
                }
                else if (p2 >= n2 - 1 && p1 < n1)
                {
                    nums3[p3] = nums1[p1];
                    p1++;
                }
                p3++;
            }
            double median;
            Console.WriteLine($"P3 = {String.Join(",", nums3)}");
            if ((n1 + n2) % 2 == 0)
            {
                Console.WriteLine($"Even Med = {nums3[needed - 1]}, {nums3[needed - 2]}, 5/2={5 / 2}");
                median = (nums3[needed - 1] + nums3[needed - 2]) / 2f;
            }
            else
            {
                Console.WriteLine($"Odd Med = {nums3[needed - 1]}");
                median = nums3[needed - 1];
            }
            return median;
        }
    }
}

