using System;
namespace Leetcode_2023
{
    public class _9_GroupAnagrams
    {
        public _9_GroupAnagrams()
        {

        }
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, IList<string>> dict = new Dictionary<string, IList<string>>();
            for (int i = 0; i < strs.Length; i++)
            {
                char[] arr = strs[i].ToCharArray();
                Array.Sort(arr);
                string sorted = new string(arr);
                if (dict.ContainsKey(sorted))
                {
                    dict[sorted].Add(strs[i]);
                }
                else
                {
                    dict.Add(sorted, new List<string>() { strs[i] });
                }
            }
            var result = dict.Values.ToList();
            return result;
        }


    }
}

