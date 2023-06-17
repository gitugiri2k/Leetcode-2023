using System;
namespace Leetcode_2023
{
	public class LT_659_Encode_Decode_Strings
	{
		public LT_659_Encode_Decode_Strings()
		{
		}
        /*
 * @param strs: a list of strings
 * @return: encodes a list of strings to a single string.
 */
        //Input: ["lint","code","love","you"]
        //Output: ["lint","code","love","you"]
        //Input: ["we", "say", ":", "yes"]
        //Output: ["we", "say", ":", "yes"]
        //encoding :;
        //lint:;code:;love:;you:;
        //we:;say:;::;yes
        public String encode(List<String> strs)
        {
            String retStr = String.Empty;
            foreach(string s in strs)
            {
                retStr += s+":;";
            }
            return retStr;
        }

        /*
         * @param str: A string
         * @return: dcodes a single string to a list of strings
         */
        public List<String> decode(String str)
        {
            str = str.TrimEnd(new char[] {':',';'});
            List<String> lStr = new List<string>();
            lStr = str.Split(":;").ToList<String>();
            return lStr;
        }
    }
}

