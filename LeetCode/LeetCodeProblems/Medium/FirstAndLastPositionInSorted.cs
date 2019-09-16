using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/
    //Given an array of integers nums sorted in ascending order, find the starting and ending position of a given target value.
    //O(log n)
    public class FirstAndLastPositionInSorted
    {
        public int[] SearchRange(int[] nums, int target)
        {

            int[] res = new int[] { -1, -1 };

            if (nums == null)
            {
                return res;


            }
            if (nums.Count() == 1)
            {
                if (nums[0] == target)
                {
                    res[0] = 0;
                    res[1] = 0;
                }
                return res;
            }

            int low = 0;
            int high = nums.Count() - 1;

            while (low <= high)
            {
                if ((nums[low] == target) && (nums[high] == target))
                {
                    res[0] = low;
                    res[1] = high;

                    return res;
                }
                if (nums[high] > target)
                    high--;

                if (nums[low] < target)
                    low++;
            }

            return res;
        }
    }
}
