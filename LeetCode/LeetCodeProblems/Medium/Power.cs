using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //Pow(x, n)
    //Implement pow(x, n), which calculates x raised to the power n (xn).
    public class Power
    {
        public double MyPow(double x, int n)
        {
            if (n == 0) return 1;
            if (n > 0) return MyPositivePow(x, n);
            else return 1.0 / MyPositivePow(x, -(long)n);
        }

        private double MyPositivePow(double x, long n)
        {
            if (n == 0) return 1;
            var half = MyPositivePow(x, n / 2);
            if (n % 2 == 0) return half * half;
            else return half * half * x;
        }
    }
}
