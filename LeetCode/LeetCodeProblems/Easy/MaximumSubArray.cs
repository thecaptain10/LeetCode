using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/maximum-subarray/
    //Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.
    public class MaximumSubArray
    {
        public int MaxSubArray(int[] nums)
        {
            int[] maxTillHere = new int[nums.Length];
            int res = nums[0];

            maxTillHere[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                //2 cases
                //nums[i] itself is > prev max.
                //nums[i] + till last index's Max

                maxTillHere[i] = Math.Max(nums[i], maxTillHere[i - 1] + nums[i]);
                res = Math.Max(res, maxTillHere[i]);
            }
            return res;
        }
    }
}
