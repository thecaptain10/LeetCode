using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/longest-palindromic-substring/submissions/
    //Given a string s, find the longest palindromic substring in s. You may assume that the maximum length of s is 1000.
    //O ( n^2 ) where n is the length of input string.
    public class LongestPalindromeSubstring
    {
        public string LongestPalindrome(string s)
        {

            if (String.IsNullOrEmpty(s))
                return string.Empty;
            int start = 0; //To Store starting index of longest palindrome string.
            int maxLength = 1;

            int len = s.Length;

            int low, high;

            //Consider both Even and Odd Length Palindromes
            for (int i = 1; i < len; i++)
            {
                //Consider Even Length Palindromes with center as i-1 and i
                low = i - 1;
                high = i;

                while (low >= 0 && high < len && s[low] == s[high])
                {
                    if (high - low + 1 > maxLength)
                    {
                        start = low;
                        maxLength = high - low + 1;
                    }
                    --low;
                    ++high;
                }

                //Consider Odd Length Palindromes with center as i
                low = i - 1;
                high = i + 1;

                while (low >= 0 && high < len && s[low] == s[high])
                {
                    if (high - low + 1 > maxLength)
                    {
                        start = low;
                        maxLength = high - low + 1;
                    }
                    --low;
                    ++high;
                }

            }

            return s.Substring(start, maxLength);
        }
    }
}
