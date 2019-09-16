using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/valid-sudoku/
    //Determine if a 9x9 Sudoku board is valid. 
    public class ValidSudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            for (var i = 0; i < 9; i++)
            {
                var hashSetRow = new HashSet<char>();

                var hashSetColumn = new HashSet<char>();

                var hashSetGrid = new HashSet<char>();

                for (var j = 0; j < 9; j++)
                {
                    if (board[i][j] != '.' && !hashSetRow.Add(board[i][j])) return false;

                    if (board[j][i] != '.' && !hashSetColumn.Add(board[j][i])) return false;

                    var x = (i % 3) * 3 + j % 3;

                    var y = (i / 3) * 3 + j / 3;

                    if (board[x][y] != '.' && !hashSetGrid.Add(board[x][y])) return false;
                }
            }

            return true;
        }

    }
}
