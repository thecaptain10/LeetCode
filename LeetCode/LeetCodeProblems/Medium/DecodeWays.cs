using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/decode-ways/
    //Greedy
    public class DecodeWays
    {
        public int NumDecodings(string s)
        {
            //dp[i] = how many ways it can decoded from 0 to i
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            var dp = new int[s.Length + 1];
            dp[0] = 1;

            for (int i = 1; i < s.Length + 1; i++)
            {
                //if string at i is 1 to 9, then dp[i] can be decoded the same number of way dp[i – 1] 
                if (s[i - 1] != '0')
                {
                    dp[i] += dp[i - 1];
                }

                //if string at i – 1 and i is between 10 to 26, then dp[i] can be decoded the same number of way dp[i – 2]
                if (i > 1 && s[i - 2] != '0' && int.Parse(s.Substring(i - 2, 2)) <= 26)
                {
                    dp[i] += dp[i - 2];
                }
            }

            return dp[s.Length];
        }
    }
}
