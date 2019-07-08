using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/word-break/
    //Given a non-empty string s and a dictionary wordDict containing a list of non-empty words, determine if s can be segmented into a space-separated sequence of one or more dictionary words.
    public class WordBreakProblem
    {
        public bool WordBreak(string s, IList<string> wordDict)
        {
            int n = s.Length;
            bool[] isWordBreak = new bool[n + 1];

            //For String of Length 0.
            isWordBreak[0] = true;

            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    //if [0..j] is not in dictionry then no point checking for remaining string.
                    if (!isWordBreak[j])
                        continue;

                    //if [0..j] is in dictionry then checking for remaining string.
                    if (wordDict.Contains(s.Substring(j, i - j)))
                    {
                        isWordBreak[i] = true;
                        break;
                    }
                }
            }
            return isWordBreak[n];
        }
    }
}
