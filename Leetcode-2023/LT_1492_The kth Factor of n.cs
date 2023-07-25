using System;
namespace Leetcode_2023
{
	public class LT_1492_The_kth_Factor_of_n
	{
		public LT_1492_The_kth_Factor_of_n()
		{
		}
        public int KthFactor(int n, int k)
        {
			for(int i = 1; i <=n/2; i++)
			{
				if (n % i == 0 && --k==0)
				{
					return i;
				}
			}
			return k == 1 ? n : -1;
        }
    }
}

