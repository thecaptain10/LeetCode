using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/multiply-strings/
    //Given two non-negative integers num1 and num2 represented as strings, return the product of num1 and num2, also represented as a string.
    public class MultiplyStrings
    {
        public string Multiply(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0")
                return "0";

            int maxLength = num1.Length + num2.Length;

            int[] digitMultiplication = new int[maxLength];

            //Multiply individual digit
            for(int i=0;i<num1.Length;i++)
            {
                for(int j = 0;j < num2.Length;j++)
                {
                    digitMultiplication[i + j + 1] += (num1[i] - '0') * (num2[j] - '0');                    
                }
            }

            // Now represent as number
            for(int i= maxLength - 1;i>0;i--)
            {
                digitMultiplication[i - 1] += digitMultiplication[i] / 10;
                digitMultiplication[i] = digitMultiplication[i] % 10;
            }

            // Convert digitMultiplication to String
            string res = "";
            int startIndex = 0;

            //Ignore leading zeroes
            while (digitMultiplication[startIndex] == 0)
                startIndex++;

            for (int i = startIndex; i < digitMultiplication.Length; i++)
                res += digitMultiplication[i];

            return res;
        }
}
