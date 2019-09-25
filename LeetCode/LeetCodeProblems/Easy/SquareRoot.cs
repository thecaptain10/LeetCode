using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/sqrtx/
    //Compute and return the square root of x, where x is guaranteed to be a non-negative integer.
    public class SquareRoot
    {
        public int MySqrt(int x)
        {

            if (x == 0) return 0;

            long left = 0;
            long right = int.MaxValue / 2 + 1;

            while (left < right)
            {
                long mid = left + (right - left) / 2;
                long candidate = mid * mid;
                if (candidate == mid)
                {
                    return (int)candidate;
                }
                else if (candidate > x)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return (int)left - 1;
        }
    }
}
