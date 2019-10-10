using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/
    //Given a sorted array nums, remove the duplicates in-place such that duplicates appeared at most twice and return the new length.
    public class RemoveDuplicatesFromSortedArrayII
    {
        public int RemoveDuplicates(int[] nums)
        {

            int n = nums.Length;

            if (n <= 2)
                return n;

            int left = 1;
            int count = 1;

            for (int i = 1; i < n; i++)
            {
                if (nums[i - 1] == nums[i])
                {
                    count++;
                    if (count <= 2)
                    {
                        nums[left] = nums[i];
                        left++;
                    }
                }
                else
                {
                    nums[left] = nums[i];
                    count = 1;
                    left++;
                }

            }
            return left;


        }
    }
}
