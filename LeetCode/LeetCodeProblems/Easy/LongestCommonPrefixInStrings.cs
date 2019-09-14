using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/longest-common-prefix/
    //Write a function to find the longest common prefix string amongst an array of strings.
    public class LongestCommonPrefixInStrings
    {
        public string LongestCommonPrefix(string[] strs)
        {

            string res = string.Empty;
            if (strs == null || strs.Count() == 0)
                return res;

            string minString = string.Empty;
            int minLength = int.MaxValue;

            for (int i = 0; i < strs.Count(); i++)
            {
                if (strs[i].Length < minLength)
                {
                    minLength = strs[i].Length;
                    minString = strs[i];
                }
            }
            bool breakOutterLoop = false;
            for (int i = 0; i < minString.Length; i++)
            {
                for (int j = 0; j < strs.Length; j++)
                {
                    if (strs[j][i] != minString[i])
                    {
                        breakOutterLoop = true;
                        break;
                    }

                }

                if (breakOutterLoop)
                    break;
                else
                    res += minString[i];

            }

            return res;
        }
    }
}
