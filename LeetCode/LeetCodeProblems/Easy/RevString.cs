using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/reverse-string/
    /*
     Write a function that reverses a string. The input string is given as an array of characters char[].

     Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
    */
    public class RevString
    {
        public void ReverseString(char[] s)
        {

            if (s == null || s.Length == 0)
                return;
            int low = 0;
            int high = s.Length - 1;

            while (low < high)
            {
                char temp = s[low];
                s[low] = s[high];
                s[high] = temp;

                low++;
                high--;
            }

        }
    }
}
