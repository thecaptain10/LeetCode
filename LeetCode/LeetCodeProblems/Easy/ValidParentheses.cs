using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/valid-parentheses/
    //Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {

            var stk = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                    stk.Push(s[i]);
                else
                {
                    if (s[i] == ')' && (!stk.Any() || stk.Pop() != '('))
                        return false;

                    if (s[i] == ']' && (!stk.Any() || stk.Pop() != '['))
                        return false;

                    if (s[i] == '}' && (!stk.Any() || stk.Pop() != '{'))
                        return false;
                }
            }

            return !stk.Any();
        }
    }
}
