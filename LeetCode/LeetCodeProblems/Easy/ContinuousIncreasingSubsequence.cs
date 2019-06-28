using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/longest-continuous-increasing-subsequence/
    //Given an unsorted array of integers, find the length of longest continuous increasing subsequence (subarray).

    public class ContinuousIncreasingSubsequence
    {
        public int FindLengthOfLCIS(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return 0;
            int n = nums.Length;

            int curr = 1;
            int ans = 1;
            for (int i = 1; i < n; i++)
            {
                if (nums[i] > nums[i - 1])
                {
                    //Keep on increasing length if this elements > previous one.
                    ++curr;
                    ans = Math.Max(ans, curr);
                }
                else
                {
                    //New Sequence Starts
                    curr = 1;
                }
            }
            return ans;
        }
    }
}
