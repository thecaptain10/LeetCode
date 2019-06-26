using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/longest-increasing-subsequence/
    /*
    Given an unsorted array of integers, find the length of longest increasing subsequence. 
    */
    //O(n*n)
    public class LongestIncreasingSubsequence
    {
        public int LengthOfLIS(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;

            //DP Approach
            int[] dp = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                dp[i] = 1;
                //From Elements from i to j index
                for (int j = 0; j < i; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                    }
                }
            }
            //Return MaxLength
            return dp.Max();
        }
    }
}
