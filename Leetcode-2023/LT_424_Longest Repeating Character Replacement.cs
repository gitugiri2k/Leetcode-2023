using System;
namespace Leetcode_2023
{
    public class LT_424_Longest_Repeating_Character_Replacement
    {
        public LT_424_Longest_Repeating_Character_Replacement()
        {
        }
        public int CharacterReplacement(string s, int k)
        {
            /*
			Input: s = "BABA", k = 2
			Output: 4
			Input: s = "AABABBA", k = 1
			Output: 4
			Explanation: Replace the two 'A's with two 'B's or vice versa.

			L=1
			R=4
			WL=3
			MaxF=2

			

			 */
            Dictionary<char, int> map = new Dictionary<char, int>();
            int result = 0;
            int left = 0, right = 0, maxFreq = 0, windowLength = right - left + 1, len = s.Length;
            while (right < len)
            {
                if (map.ContainsKey(s[right]))
                {
                    map[s[right]]++;
                    maxFreq = Math.Max(maxFreq, map[s[right]]);
                }
                else
                {
                    map[s[right]] = 1;
                    maxFreq = Math.Max(maxFreq, 1);
                }
                windowLength = right - left + 1;
                while (windowLength - maxFreq > k)
                {
                    map[s[left]]--;
                    left++;
                    windowLength = right - left + 1;
                }
                right++;
                result = Math.Max(windowLength, result);
            }
            return result;
        }
    }
}

