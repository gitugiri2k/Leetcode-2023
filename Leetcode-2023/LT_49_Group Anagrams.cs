using System;
namespace Leetcode_2023
{
    public class LT_49_Group_Anagrams
    {
        public LT_49_Group_Anagrams()
        {
        }
        /*
Given an array of strings strs, group the anagrams together. You can return the answer in any order.
An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
Example 1:
Input: strs = ["eat","tea","tan","ate","nat","bat"]
sortedStrs [aet,aet,ant,aet,ant,abt]
aet:["eat","tea","ate"]
ant:["tan","nat"]
abt:["bat"]
Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
*/
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            char[] c;
            string sortedStr;
            Dictionary<string, IList<string>> ss = new Dictionary<string, IList<string>>();
            for(int i = 0; i < strs.Length; i++)
            {
                c = strs[i].ToCharArray();
                Array.Sort(c);
                sortedStr = new string(c);
                if (!ss.ContainsKey(sortedStr)){
                    ss[sortedStr].Add(strs[i]);
                }
                else
                {
                    ss[sortedStr].Add(strs[i]);
                }
            }
            return ss.Values.ToList();
        }
    }
}

