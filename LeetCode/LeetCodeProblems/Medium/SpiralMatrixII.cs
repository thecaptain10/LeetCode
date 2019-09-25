using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/spiral-matrix-ii/
    //Given a positive integer n, generate a square matrix filled with elements from 1 to n2 in spiral order.
    public class SpiralMatrixII
    {
        public int[][] GenerateMatrix(int n)
        {

            var res = new int[n][];

            for (int i = 0; i < n; i++)
            {
                res[i] = new int[n];
            }


            int top = 0;
            int bottom = n - 1;
            int left = 0;
            int right = n - 1;

         
            int num = 1;

            while (true)
            {
                //Left To Right
                for (int i = left; i <= right; i++)
                    res[top][i] = num++;
                top++;

                if (top > bottom) break;

                //Top To Bottom
                for (int i = top; i <= bottom; i++)
                    res[i][right] = num++;
                right--;

                if (right < left) break;

                //Right To Left
                for (int i = right; i >= left; i--)
                    res[bottom][i] = num++;
                bottom--;

                if (bottom < top) break;

                //Bottom To Top
                for (int i = bottom; i >= top; i--)
                    res[i][left] = num++;
                left++;

                if (left > right) break;

            }

            return res;

        }
    }
}
