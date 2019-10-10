using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/set-matrix-zeroes/
    //Given a m x n matrix, if an element is 0, set its entire row and column to 0. Do it in-place.
    public class SetMatrixZeroes
    {
        public void SetZeroes(int[][] matrix)
        {

            int m = matrix.Length;
            int n = matrix[0].Length;

            //Identify rows and columns containing Zeroes in input, Zerofy all rows and columns
            List<int> rowsWithZero = new List<int>();
            List<int> columnsWithZero = new List<int>();

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        if (!rowsWithZero.Contains(i))
                            rowsWithZero.Add(i);
                        if (!columnsWithZero.Contains(j))
                            columnsWithZero.Add(j);
                    }
                }
            }

            for (int i = 0; i < m; i++)
            {
                if (rowsWithZero.Contains(i))
                {
                    for (int j = 0; j < n; j++)
                        matrix[i][j] = 0;
                }
            }


            for (int i = 0; i < n; i++)
            {
                if (columnsWithZero.Contains(i))
                {
                    for (int j = 0; j < m; j++)
                        matrix[j][i] = 0;
                }
            }

            return;

        }
    }
}
