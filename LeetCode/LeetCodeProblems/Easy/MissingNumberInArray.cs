using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/missing-number/
    //Given an array containing n distinct numbers taken from 0, 1, 2, ..., n, find the one that is missing from the array.
    public class MissingNumberInArray
    {
        public int MissingNumber(int[] nums)
        {
            int n = nums.Length;

            if (n == 0)
                return 0;

            long sumOfNNumbers = n * (n + 1) / 2;

            for (int i = 0; i < n; i++)
            {
                sumOfNNumbers -= (long)nums[i];
            }
            return (int)sumOfNNumbers;
        }
    }
}
