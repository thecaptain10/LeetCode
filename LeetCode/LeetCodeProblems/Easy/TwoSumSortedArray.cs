using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
    //Given an array of integers that is already sorted in ascending order, find two numbers such that they add up to a specific target number.
    public class TwoSumSortedArray
    {
        public int[] TwoSum(int[] numbers, int target)
        {

            int n = numbers.Length;
            int left = 0;
            int right = n - 1;

            while (left < right)
            {
                int result = numbers[left] + numbers[right];
                if (result == target)
                {
                    return new int[] { left + 1, right + 1 };
                }
                else if (result < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return null;
        }
    }
}
