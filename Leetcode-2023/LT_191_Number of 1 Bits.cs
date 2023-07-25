using System;
namespace Leetcode_2023
{
	public class LT_191_Number_of_1_Bits
	{
		public LT_191_Number_of_1_Bits()
		{
		}
        public int HammingWeight(uint n)
        {
			int res = 0;
			while (n > 0)
			{
				res += (int) n % 2;
				n = n >> 1;
			}
			return res;
        }
        public int[] CountBits(int n)
        {
			int[] a = new int[n + 1];
			for(int i = 0; i <= n; i++)
			{
				a[i] = HammingWeight((uint)i);
            }
			return a;
        }
    }
}

