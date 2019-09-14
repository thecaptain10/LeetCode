using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/reverse-integer/
    //Given a 32-bit signed integer, reverse digits of an integer.
    public class ReverseIntegerNumber
    {
        public int Reverse(int x)
        {
            long res = 0;
            bool isPositive = true;
            if (x < 0)
            {
                isPositive = false;
                x *= (-1);
            }
            while (x / 10 > 0)
            {
                int rem = x % 10;

                res = res * 10 + rem;

                x /= 10;

            }

            res = res * 10 + x;

            return (res <= Math.Pow(-2, 31) || res >= Math.Pow(2, 31) - 1) ? 0 : isPositive ? (int)res : (int)-res;
        }
    }
}
