using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/divide-two-integers/
    //Given two integers dividend and divisor, divide two integers without using multiplication, division and mod operator.
    public class DivideTwoIntegers
    {
        private long DividePositive(long dividend, long divisor)
        {
            if (dividend < divisor) { return 0; }

            int power = 1, cnt = 1;

            while ((divisor << power) <= dividend)
            {
                power++;
                cnt *= 2;
            }

            long leftover = dividend - (divisor << (power - 1));

            return cnt + DividePositive(leftover, divisor);
        }

        public int Divide(int dividend, int divisor)
        {
            if (dividend == 0) { return 0; }
            if (dividend == int.MinValue && divisor == -1) { return int.MaxValue; }

            int sign = (divisor > 0) ^ (dividend > 0) ? -1 : 1;

            long lDividend = Math.Abs((long)dividend);
            long lDivisor = Math.Abs((long)divisor);

            int res = (int)DividePositive(lDividend, lDivisor);

            return res * sign;
        }
    }
}
