using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/palindrome-number/
    //Determine whether an integer is a palindrome. An integer is a palindrome when it reads the same backward as forward.
    public class IsPalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            //all negetive integer are not palindrome
            if (x < 0)
            {
                return false;
            }
            else
            {
                int y = 0;
                int temp = x;
                while (temp != 0)
                {
                    y = y * 10 + temp % 10;
                    temp = temp / 10;
                }
                if (y == x)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
