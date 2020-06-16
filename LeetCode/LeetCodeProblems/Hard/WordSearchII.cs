using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Hard
{
    //https://leetcode.com/problems/word-search-ii/
    //Given a 2D board and a list of words from the dictionary, find all words in the board.
    //Each word must be constructed from letters of sequentially adjacent cell, where "adjacent" cells are those horizontally or vertically neighboring.The same letter cell may not be used more than once in a word.
    public class TrieNode
    {        
        public string Word { get; set; }

        public TrieNode[] trieNodes = new TrieNode[26];

        public TrieNode Next(char c)
        {
            return this.trieNodes[c - 'a'];
        }

        public void DeDuplicate()
        {
            Word = null;
        }
    }
    public class Trie
    {
        public TrieNode root;

        public Trie()
        {
            this.root = new TrieNode();
        }

        /** Inserts a word into the trie. */
        public void Insert(string word)
        {
            TrieNode current = root;
            for (int i = 0; i < word.Length; i++)
            {
                if (current.trieNodes[word[i] - 'a'] == null)
                    current.trieNodes[word[i] - 'a'] = new TrieNode();

                current = current.Next(word[i]);
            }
            current.Word = word;
        }

    }

    public class WordSearchII
    {
        IList<string> res = new List<string>();

        public IList<string> FindWords(char[][] board, string[] words)
        {
            Trie trie = new Trie();

            foreach (string word in words)
                trie.Insert(word);

            TrieNode root = trie.root;

            int rows = board.Length;
            int columns = board[0].Length;

            for(int i=0;i<rows;i++)
            {
                for(int j=0;j<columns;j++)
                {
                    DFS(board, words, i, j, root);
                }
            }

            return res;
        }

        private void DFS(char[][] board, string[] words, int row, int column, TrieNode trieNode)
        {
            char ch = board[row][column];

            //Skip visited ones
            if (ch == '#' || trieNode.Next(ch) == null)
                return;

            trieNode = trieNode.Next(ch);

            //If word is found and not already present, add to result.
            if (!string.IsNullOrWhiteSpace(trieNode.Word) && !res.Contains(trieNode.Word))
                res.Add(trieNode.Word);

            //Mark as visited
            board[row][column] = '#';

            //if word not present move in all deirections
            int rows = board.Length;
            int columns = board[0].Length;

            //Move Up
            if (row > 0)
                DFS(board, words, row - 1, column, trieNode);

            //Move Down
            if (row < rows - 1)
                DFS(board, words, row + 1, column, trieNode);

            //Move Left 
            if (column > 0)
                DFS(board, words, row, column - 1, trieNode);

            //Move Right
            if (column < columns - 1)
                DFS(board, words, row, column + 1, trieNode);

            // Back Track
            board[row][column] = ch;

        }
    }
}
