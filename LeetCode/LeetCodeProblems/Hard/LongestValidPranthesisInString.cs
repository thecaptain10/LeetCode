using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Hard
{
    //https://leetcode.com/problems/longest-valid-parentheses/
    //Given a string containing just the characters '(' and ')', find the length of the longest valid (well-formed) parentheses substring.
    //https://www.geeksforgeeks.org/length-of-the-longest-valid-substring/
    public class LongestValidPranthesisInString
    {
        public int LongestValidParentheses(string s)
        {
            int maxLength = 0;

            if (string.IsNullOrEmpty(s))
                return maxLength;

            //Idea is to store indexes instead of chars

            Stack<int> stack = new Stack<int>();
            stack.Push(-1);

            int length = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                    stack.Push(i);
                else
                {

                    stack.Pop();
                    if (stack.Any())
                    {
                        length = i - stack.Peek();
                        if (maxLength < length)
                            maxLength = length;

                    }
                    else
                    {
                        stack.Push(i);
                    }

                }

            }

            return maxLength;
        }
    }
}
