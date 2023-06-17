using System;
namespace Leetcode_2023
{
	public class _42_ValidAnagram
	{
		public _42_ValidAnagram()
		{
		}
        public bool IsAnagram(string s, string t)
        {
			char[] s1 = s.ToCharArray();
			char[] t1 = t.ToCharArray();
			Array.Sort(s1);
			s=new string(s1);
			Array.Sort(t1);
			t=new string(t1);
			if (s == t)
			{
				return true;
			}
			return false;
        }
    }
}

