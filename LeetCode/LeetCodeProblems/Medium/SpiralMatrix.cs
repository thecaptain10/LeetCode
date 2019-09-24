using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/spiral-matrix/
    //Given a matrix of m x n elements (m rows, n columns), return all elements of the matrix in spiral order.
    public class SpiralMatrix
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            IList<int> res = new List<int>();

            int m = matrix.Length;

            if (m == 0)
                return res;

            int n = matrix[0].Length;

            int top = 0;
            int bottom = m - 1;
            int left = 0;
            int right = n - 1;


            while(true)
            {
                //Left To Right
                for (int i = left; i <= right; i++)
                    res.Add(matrix[top][i]);
                top++;

                if (top > bottom) break;

                //Top To Bottom
                for (int i = top; i <= bottom; i++)
                    res.Add(matrix[i][right]);
                right--;

                if (right < left) break;
                
                //Right To Left
                for (int i = right; i >= left; i--)
                    res.Add(matrix[bottom][i]);
                bottom--;

                if (bottom < top) break;
                
                //Bottom To Top
                for (int i = bottom; i >= top; i--)
                    res.Add(matrix[i][left]);
                left++;

                if (left > right) break;
            
            }
                       
            return res;

        }
    }
}
