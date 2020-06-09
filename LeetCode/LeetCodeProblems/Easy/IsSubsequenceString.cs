using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/is-subsequence/
    //Given a string s and a string t, check if s is subsequence of t.
    //O(n) Time, O(1)Space
    public class IsSubsequenceString
    {
        public bool IsSubsequence(string s, string t)
        {
            int m = s.Length;
            int n = t.Length;
            int j = 0;
            for (int i = 0; i < n && j < m; i++)
            {
                if (s[j] == t[i])
                    j++;
            }

            return (j == m);
        }
    }
}
