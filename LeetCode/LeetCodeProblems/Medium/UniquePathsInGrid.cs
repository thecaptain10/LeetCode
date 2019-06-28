
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/unique-paths/
    /*
        A robot is located at the top-left corner of a m x n grid (marked 'Start' in the diagram below).

        The robot can only move either down or right at any point in time. The robot is trying to reach the bottom-right corner of the grid (marked 'Finish' in the diagram below).

        How many possible unique paths are there?
     */
    public class UniquePathsInGrid
    {
        public int UniquePaths(int m, int n)
        {
            int[,] dp = new int[m + 1, n + 1];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dp[i, j] = 0;
                    if (i == 0 && j == 0)
                        dp[i, j] = 1;
                    //Consider Down Direction
                    if (i > 0)
                        dp[i, j] += dp[i - 1, j];
                    //Consider Right Direction
                    if (j > 0)
                        dp[i, j] += dp[i, j - 1];
                }
            }
            return dp[m - 1, n - 1];
        }
    }
}
