using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/maximum-product-subarray/
    //Given an integer array nums, find the contiguous subarray within an array (containing at least one number) which has the largest product.
    //DP
    //O(n)
    public class MaxProductSubarray
    {
        public int MaxProduct(int[] nums)
        {
            int[] maxTillHere = new int[nums.Length];
            //To Keep Track of Max -ve Product Till now.
            int[] minTillHere = new int[nums.Length];
            int res = nums[0];

            maxTillHere[0] = nums[0];
            minTillHere[0] = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                //3 cases
                //nums[i] itself is > prev max.
                //nums[i] is +Ve so multiply by till last index's Max
                //nums[i] is -Ve so multiply by till last index's Min
                maxTillHere[i] = Math.Max(nums[i], Math.Max(maxTillHere[i - 1] * nums[i], minTillHere[i - 1] * nums[i]));
                minTillHere[i] = Math.Min(nums[i], Math.Min(maxTillHere[i - 1] * nums[i], minTillHere[i - 1] * nums[i]));
                //Compare between prev max ,curr max
                res = Math.Max(res, maxTillHere[i]);
            }

            return res;
        }
    }
}
