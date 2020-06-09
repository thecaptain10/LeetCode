using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/move-zeroes/
    //Given an array nums, write a function to move all 0's to the end of it while maintaining the relative order of the non-zero elements.
    //O(n)
    public class MoveZeroesAtEnd
    {
        public void MoveZeroes(int[] nums)
        {

            int index = 0;
            int n = nums.Length;
            if (n == 0) return;
            for (int i = 0; i < n; i++)
            {
                if (nums[i] != 0)
                {
                    nums[index++] = nums[i];
                }
            }
            for (int j = index; j < n; j++)
            {
                nums[j] = 0;
            }
        }
    }
}
