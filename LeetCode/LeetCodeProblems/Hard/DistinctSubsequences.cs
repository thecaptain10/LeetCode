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

            //C[i][j] = C[i-1][j]. No matter what current char of S is we simply don't use it. We will only use chars [0,...i-2] from S no matter how many solutions there are to cover T[0...j-1]
            // But if current char of S is same to current of T (S[i - 1] == T[j - 1]) then we have another choice: we can use all the solutions of C[i - 1][j - 1] to increment the solution C[i][j].Therefore C[i][j] += C[i - 1][j - 1]

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
