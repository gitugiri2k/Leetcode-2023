
using System;
namespace Leetcode_2023
{
    public class LT_2259_Remove_Digit_From_Number_to_Maximize_Result
    {
        public LT_2259_Remove_Digit_From_Number_to_Maximize_Result()
        {
        }
        public string RemoveDigit(string number, char digit)
        {
            int len = number.Length;
            List<Int32> results = new List<Int32>();
            for (int i = 0; i < len; i++)
            {
                if (number[i] == digit)
                {
                    results.Add(Int32.Parse(number.Substring(0, i) + number.Substring(i + 1)));
                }
            }
            if (results.Count == 0)
                return null;
            return results.Max().ToString();
        }
    }
}

