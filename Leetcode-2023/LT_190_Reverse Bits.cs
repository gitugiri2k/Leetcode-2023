using System;
namespace Leetcode_2023
{
	public class LT_190_Reverse_Bits
	{
		public LT_190_Reverse_Bits()
		{
		}
        public uint reverseBits(uint n)
        {
			uint reversed = 0;
			for(int i=0;i<32;i++)
			{
                reversed = reversed << 1;
                if (n % 2 == 1)
					reversed++;
				n=n >> 1;
			}
			return reversed;
        }
    }
}

