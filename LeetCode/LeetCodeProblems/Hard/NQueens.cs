using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Hard
{
    //https://leetcode.com/problems/n-queens/
    //The n-queens puzzle is the problem of placing n queens on an n×n chessboard such that no two queens attack each other.
    public class NQueens
    {
        public IList<IList<string>> SolveNQueens(int n)
        {
            IList<IList<string>> res = new List<IList<string>>();

            if (n == 0)
                return res;

            int[,] board = new int[n,n];

            if(SolveNQueensUtil(board, 0,n, res) == false)
            {
                return res;

            }


            return res;


        }

        private bool SolveNQueensUtil(int[,] board, int col, int boardSize, IList<IList<string>> res)
        {
            if(col>=boardSize)
            {
                List<string> tempList = new List<string>();
                for (int i = 0; i < boardSize; i++)
                {
                    StringBuilder sb = new StringBuilder();
                    for (int j = 0; j < boardSize; j++)
                    {
                        if (board[i, j] == 1)
                            sb.Append("Q");
                        else
                            sb.Append(".");
                    }
                    tempList.Add(sb.ToString());
                }
                res.Add(tempList);

                //Just to return all possible solutions. return true for only one solution.
                return false;
            }

            for(int i=0;i<boardSize;i++)
            {
                if (IsSafe(board, i, col, boardSize))
                {
                    //Place Queen at this position.
                    board[i,col] = 1;

                    //Recur to place queen on next columns
                    if (SolveNQueensUtil(board, col + 1, boardSize, res))
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
            for(int i=0;i<col;i++)
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
