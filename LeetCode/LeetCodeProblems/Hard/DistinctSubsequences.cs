using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Hard
{
    public class DistinctSubsequences
    {
        //https://leetcode.com/problems/distinct-subsequences/
        //Given a string S and a string T, count the number of distinct subsequences of S which equals T.
        public int numDistinct(string s, string t)
        {
            int m = s.Length;
            int n = t.Length;
            int[,] dp = new int[m + 1, n + 1];

            for (int i = 0; i <= m; i++)
            {
                dp[i, 0] = 1;
            }

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (s[i - 1] == t[j - 1])
                    {
                        dp[i, j] += dp[i - 1, j] + dp[i - 1, j - 1];
                    }
                    else
                    {
                        dp[i, j] += dp[i - 1, j];
                    }
                }
            }
            return dp[m, n];
        }
    }
}
