using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/implement-strstr/
    //Return the index of the first occurrence of needle in haystack, or -1 if needle is not part of haystack.
    public class ImplementStrStr
    {
        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
                return 0;

            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                for (int j = 0; j < needle.Length; j++)
                {
                    if (haystack[i + j] != needle[j])
                        break;

                    if (j == needle.Length - 1)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}
