using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/search-in-rotated-sorted-array/
    //Find target value in an array sorted in ascending order is rotated at some pivot unknown to you beforehand.
    public class SearchInRotatedSortedArray
    {
        public int Search(int[] nums, int target)
        {

            var n = nums.Length;

            var left = 0;
            var right = n - 1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (nums[mid] == target) return mid;
                else if (nums[mid] <= nums[right])
                {
                    // right part is ordered
                    if (nums[mid] < target && target <= nums[right])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
                else if (nums[mid] >= nums[right])
                {
                    // left part is ordered
                    if (nums[left] <= target && target < nums[mid])
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
            }

            return -1;
        }
    }
}
