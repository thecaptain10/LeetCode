using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/search-insert-position/
    //Given a sorted array and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.
    public class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            int n = nums.Count();
            int low = 0;
            int high = n - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] < target)
                    low = mid + 1;
                else
                    high = mid - 1;
            }

            return low;
        }
    }
}
