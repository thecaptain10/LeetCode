using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LeetCodeProblems.Hard
{
    //https://leetcode.com/problems/n-queens-ii/
    //Given an integer n, return the number of distinct solutions to the n-queens puzzle.
    public class NQueensII
    {
        int count = 0;
        public int TotalNQueens(int n)
        {
            if (n == 0)
                return count;

            int[,] board = new int[n, n];

            if (SolveNQueensUtil(board, 0, n) == false)
            {
                return count;
            }            
            return count;
            
        }

        private bool SolveNQueensUtil(int[,] board, int col, int boardSize)
        {
            if (col >= boardSize)
            {
                count += 1;

                //Just to return all possible solutions. return true for only one solution.
                return false;
            }

            for (int i = 0; i < boardSize; i++)
            {
                if (IsSafe(board, i, col, boardSize))
                {
                    //Place Queen at this position.
                    board[i, col] = 1;

                    //Recur to place queen on next columns
                    if (SolveNQueensUtil(board, col + 1, boardSize))
                        return true;
                    else
                        board[i, col] = 0;
                }
            }
            //If Queen can't be placed in any row for given column.
            return false;
        }

        private bool IsSafe(int[,] board, int row, int col, int boardSize)
        {

            //Check row if any column already contains queen.
            for (int i = 0; i < col; i++)
            {
                if (board[row, i] == 1)
                    return false;
            }

            //Check Upper - left Diagonal
            for (int i = row, j = col; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i, j] == 1)
                    return false;
            }

            //Check botttom  - left Diagonal
            for (int i = row, j = col; i < boardSize && j >= 0; i++, j--)
            {
                if (board[i, j] == 1)
                    return false;
            }
            return true;
        }
    }
}
