using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/unique-binary-search-trees/
    //Given n, how many structurally unique BST's (binary search trees) that store values 1 ... n?

    public class UniqueBSTCount
    {
        public int NumTrees(int n)
        {

            int[] dp = new int[n + 2];

            //dp[i] reprsents number of unique tree from numbers 1..i
            dp[0] = 1;
            dp[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    //if we choose j as root, j-1 nums will be on left and i-j will be at right. So multiply for combinations.
                    dp[i] += dp[j - 1] * dp[i - j];
                }
            }
            return dp[n];
        }
    }
}
