using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/plus-one/
    //Given a non-empty array of digits representing a non-negative integer, plus one to the integer.The digits are stored such that the most significant digit is at the head of the list, and each element in the array contain a single digit.
    public class PlusOneToIntInArray
    {
        public int[] PlusOne(int[] digits)
        {
            List<int> result = new List<int>();

            int carry = 0;
            int n = digits.Length;

            for (int i = n - 1; i >= 0; i--)
            {
                int oneResult = digits[i] + carry;
                if (i == n - 1)
                {
                    oneResult += 1;
                }
                carry = oneResult / 10;
                result.Add(oneResult % 10);
            }

            if (carry != 0)
            {
                result.Add(carry);
            }

            result.Reverse();

            return result.ToArray();
        }
    }
}
