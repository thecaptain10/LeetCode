using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/3sum-closest/
    //Given an array nums of n integers and an integer target, find three integers in nums such that the sum is closest to target. Return the sum of the three integers.
    public class _3SumClosest
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            int res = int.MaxValue;
            var globalSum = 0;
            if (nums == null || nums.Count() < 3)
                return res;

            //Sort the array
            Array.Sort(nums);

            for (int i = 0; i < nums.Count(); i++)
            {
                //Fix First Element
                int low = i + 1;
                int high = nums.Count() - 1;

                //Since array is sorted, shrink based on sum value.
                while (low < high)
                {
                    int sum = nums[i] + nums[low] + nums[high];
                    var localClosest = Math.Abs(sum - target);
                    if (sum == target)
                    {
                        return target;
                    }
                    else if (sum < target)
                    {
                       low++;
                    }
                    else
                    {
                        high--;
                    }

                    if(res > localClosest)
                    {
                        res = localClosest;
                        globalSum = sum;
                    }
                }
            }



            return globalSum;
        }
    }
}
