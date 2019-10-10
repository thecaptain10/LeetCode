using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/search-a-2d-matrix/
    /*
    Write an efficient algorithm that searches for a value in an m x n matrix. This matrix has the following properties:
        Integers in each row are sorted from left to right.
        The first integer of each row is greater than the last integer of the previous row.
    */
    public class Search2DMatrix
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {

            int m = matrix.Length;

            if (m == 0)
                return false;

            int n = matrix[0].Length;

            //start from bottom left
            int i = m - 1;
            int j = 0;

            while (i >= 0 && j < n)
            {
                if (matrix[i][j] == target)
                    return true;
                else if (matrix[i][j] > target)
                    i--;
                else
                    j++;
            }

            return false;
        }
    }
}
