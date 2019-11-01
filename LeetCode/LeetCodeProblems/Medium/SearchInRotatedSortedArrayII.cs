using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/search-in-rotated-sorted-array-ii/
    //Suppose an array sorted in ascending order is rotated at some pivot unknown to you beforehand.
    //    (i.e., [0, 0, 1, 2, 2, 5, 6] might become[2, 5, 6, 0, 0, 1, 2]).
    //You are given a target value to search.If found in the array return true, otherwise return false.
    public class SearchInRotatedSortedArrayII
    {
        public bool Search(int[] nums, int target)
        {

            var n = nums.Length;

            var left = 0;
            var right = n - 1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (nums[mid] == target) return true;
                if (nums[right] == target || nums[left] == target) return true;
                if (nums[left] < nums[mid])
                {
                    if (target > nums[left] && target < nums[mid]) right = mid - 1;
                    else left = mid + 1;
                }
                else if (nums[right] > nums[mid])
                    if (target > nums[mid] && target < nums[right]) left = mid + 1;
                    else right = mid - 1;
                else
                    right--;
            }

            return false;
        }
    }
}
