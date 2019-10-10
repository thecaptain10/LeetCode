using LeetCodeProblems.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/word-search/
    //Given a 2D board and a word, find if the word exists in the grid.
    //The word can be constructed from letters of sequentially adjacent cell, where "adjacent" cells are those horizontally or vertically neighboring.The same letter cell may not be used more than once.
    public class WordSearch
    {
        int n;
        int m;
        public bool Exist(char[][] board, string word)
        {
            n = board.Length;

            if (n == 0)
                return false;
            bool result = false;
            m = board[0].Length;

            var isVisited = new bool[n, m];


            for (int i=0;i<n;i++)
            {
                for(int j=0;j<m;i++)
                {
                    result = DFS(board, isVisited, i, j, word, 0);

                    if (result)
                        return true;
                }
            }

            return result;

        }

        private bool DFS(char[][] board, bool[,] isVisited, int x, int y, string word, int wordIndex)
        {
            //Word is found
            if (word.Length == wordIndex)
                return true;

            //Array Bounds check
            if (x < 0 || x == n || y < 0 || y == m)
                return false;

            
            //if it is mismatch
            if (word[wordIndex] != board[x][y])
            {
                return false;
            }
            //Element already visited
            if (isVisited[x, y])
                return false;


            //mark current element as visited
            isVisited[x, y] = true;


            var directions = new (int, int)[] { (0, 1), (0, -1), (1, 0), (-1, 0) };

            //Iterate over all directions
            foreach (var direction in directions)
            {
                var oneResult = DFS(board, isVisited, x + direction.Item1, y + direction.Item2, word, wordIndex + 1);
                if (oneResult) return true;
            }

            //Backtrack : unmark current visted element.
            isVisited[x, y] = false;

            return false;
        }
    }
}
