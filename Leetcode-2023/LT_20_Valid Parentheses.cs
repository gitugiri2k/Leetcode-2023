using System;
namespace Leetcode_2023
{
	public class LT_20_Valid_Parentheses
	{
		public LT_20_Valid_Parentheses()
		{
		}
        public bool IsValid(string s)
        {

			/*
			 * Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.
 

Example 1:

Input: s = "()"
Output: true
Example 2:

Input: s = "()[]{}"
Output: true

Input: s = "())[]{}"
Output: false

			angleCnt, sqCnt, RndCnt=0;
			if(s[i]=="("){
			RndCnt++;
			}
			 */
			Stack<char> stk = new Stack<char>();
            foreach (char c in s)
			{
				if (c == '(' || c == '{' || c == '[')
					stk.Push(c);
				else
				{
					char c1;
					if (stk.TryPeek(out c1))
					{
						if ((c1 == '(' && c != ')') || (c1 == '{' && c != '}') || (c1 == '[' && c != ']'))
							return false;
						stk.Pop();
                    }
					else
						return false;
				}
			}
			if(stk.Count==0)
				return true;
			return false;
        }
    }
}

