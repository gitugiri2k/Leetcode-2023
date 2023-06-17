using System;
namespace Leetcode_2023
{
    public class LT_3_Longest_Substring_Without_Repeating_Characters
    {
        public LT_3_Longest_Substring_Without_Repeating_Characters()
        {
        }
        /*
        Input: s = "abcabcbb"
        Output: 3
        Explanation: The answer is "abc", with the length of 3.
        Conditions for SW =
        1. Array - Yes
        2. Substring - Yes
        3. Window Size = No
        This is a variable window size sw problem
         */
        public int LengthOfLongestSubstring(string s)
        {
            int max = 0,windowSize = 00;
            Dictionary<char, int> aDict = new Dictionary<char, int>();
            int i = 0, j = 0;
            while (j < s.Length)
            {
                if (!aDict.ContainsKey(s[j])){
                    aDict.Add(s[j], 1);
                }
                else
                aDict[s[j]] = aDict[s[j]]+1;
                windowSize = (j - i) + 1;
                if (aDict.Count == windowSize)
                {
                    max = Math.Max(windowSize, max);
                    j++;
                }
                else if (aDict.Count < windowSize)
                {
                    while (aDict.Count < windowSize){
                        aDict[s[i]] = aDict[s[i]] - 1;
                        if (aDict[s[i]] == 0)
                        {
                            aDict.Remove(s[i]);
                        }
                        i++;
                        windowSize = j - i + 1;
                    }
                    j++;
                }
            }
            return max;
        }
    }
}

