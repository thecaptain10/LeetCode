using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/excel-sheet-column-title/
    //Given a positive integer, return its corresponding column title as appear in an Excel sheet.
    public class ExcelSheetColumnTitle
    {
        public string ConvertToTitle(int n)
        {

            string result = string.Empty;

            while (n > 0)
            {
                n--;
                int x = n % 26;
                result = (char)(x + 65) + result;
                n = n / 26;
            }
            return result;
        }



    }
}
