using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/zigzag-conversion/
    //The string "PAYPALISHIRING" is written in a zigzag pattern on a given number of rows like this: (you may want to display this pattern in a fixed font for better legibility)
    public class ZigZagStringConversion
    {
        public string Convert(string s, int numRows)
        {

            if (numRows == 1)
                return s;

            string res = string.Empty;
            bool down = true;

            string[] rows = new string[numRows];


            for (int i = 0; i < s.Length; i++)
            {
                if (down)
                {
                    for (int j = 0; j < numRows; j++)
                    {
                        if (i < s.Length)
                            rows[j] += s[i++];
                    }

                    down = !down;
                }
                else
                {
                    for (int j = numRows - 2; j > 0; j--)
                    {
                        if (i < s.Length)
                            rows[j] += s[i++];
                    }
                    down = !down;
                }
                if (i < s.Length)
                {
                    i--;
                }

            }
            for (int i = 0; i < numRows; i++)
                res += rows[i];


            return res;
        }
    }
}
