using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/unique-paths-ii/
    /*
        A robot is located at the top-left corner of a m x n grid (marked 'Start' in the diagram below).

        The robot can only move either down or right at any point in time. The robot is trying to reach the bottom-right corner of the grid (marked 'Finish' in the diagram below).

        Now consider if some obstacles are added to the grids. How many unique paths would there be? 
    */
    public class UniquePathsInGridWithObstacles
    {
        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {

            if (obstacleGrid == null || obstacleGrid.Length == 0)
            {
                return 0;
            }

            int m = obstacleGrid.Length;
            int n = obstacleGrid[0].Length;

            //For case Like [[1]]
            if (obstacleGrid[0][0] == 1 || obstacleGrid[m - 1][n - 1] == 1)
            {
                return 0;
            }
            int[,] dp = new int[m + 1, n + 1];
            
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    dp[i, j] = 0;
                    if (i == 0 && j == 0)
                        dp[i, j] = 1;
                    //If there is obstacle, leave that path.
                    if (obstacleGrid[i][j] == 1)
                    {
                        continue;
                    }
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
