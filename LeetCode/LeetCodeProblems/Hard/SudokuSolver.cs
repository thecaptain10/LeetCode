using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Hard
{
    //https://leetcode.com/problems/sudoku-solver/
    //Write a program to solve a Sudoku puzzle by filling the empty cells.
    public class SudokuSolver
    {
        public void SolveSudoku(char[][] board)
        {
            if (board == null || board.Length == 0) return;
            SolveSudokuInternal(board);
        }

        public bool SolveSudokuInternal(char[][] board)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (board[i][j] == '.')
                    {
                        for (char c = '1'; c <= '9'; c++)
                        {
                            if (IsValid(board, c, i, j))
                            {
                                board[i][j] = c;
                                if (SolveSudokuInternal(board))
                                    return true;
                                else
                                    board[i][j] = '.';
                            }
                        }

                        return false;
                    }
                }
            }

            return true;
        }

        public bool IsValid(char[][] board, char ch, int row, int col)
        {
            for (int i = 0; i < 9; i++)
                if (board[row][i] == ch)
                    return false;

            for (int i = 0; i < 9; i++)
                if (board[i][col] == ch)
                    return false;

            int r = (row / 3) * 3, c = (col / 3) * 3;

            for (int i = r; i < r + 3; i++)
                for (int j = c; j < c + 3; j++)
                    if (board[i][j] == ch)
                        return false;

            return true;
        }
    }
}
