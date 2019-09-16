using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/remove-element/
    //Given an array nums and a value val, remove all instances of that value in-place and return the new length.
    public class RemoveElementFromArray
    {
        public int RemoveElement(int[] nums, int val)
        {
            int i = -1;
            foreach (int num in nums)
            {
                if (num != val)
                    nums[++i] = num;
            }
            return i + 1;
        }
    }
}
