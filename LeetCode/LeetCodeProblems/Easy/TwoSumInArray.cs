using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/two-sum/
    //Given an array of integers, return indices of the two numbers such that they add up to a specific target.
    public class TwoSumInArray
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for(int i=0;i<nums.Length;i++)
            {
                int remainder = target - nums[i];

                if (dict.ContainsKey(remainder))
                    return new int[] { dict[remainder], i };

                if (!dict.ContainsKey(nums[i]))
                    dict.Add(nums[i], i);
            }
            return new int[] { };
        }
    }
}
