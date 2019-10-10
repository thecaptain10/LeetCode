using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{

    //https://leetcode.com/problems/sort-colors/
    //Given an array with n objects colored red, white or blue, sort them in-place so that objects of the same color are adjacent, with the colors in the order red, white and blue.
    //Here, we will use the integers 0, 1, and 2 to represent the color red, white, and blue respectively.
    //O(n)
    public class SortColor
    {
        public void SortColors(int[] nums)
        {

            int n = nums.Length;

            if (n == 0)
                return;

            int left = 0;
            int right = n - 1;

            for (int i = 0; i <= right; i++)
            {
                if (nums[i] == 2)
                {
                    var temp = nums[right];
                    nums[right] = nums[i];
                    nums[i] = temp;

                    right--;
                    i--;
                }
                else if (nums[i] == 0)
                {
                    var temp = nums[left];
                    nums[left] = nums[i];
                    nums[i] = temp;

                    left++;
                }
            }

        }
    }
}
