using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/add-and-search-word-data-structure-design/
    //Add and Search Word - Data structure design
    public class WordDictionary
    {
        TrieNode root;

        /** Initialize your data structure here. */
        public WordDictionary()
        {
            root = new TrieNode();
        }

        /** Adds a word into the data structure. */
        public void AddWord(string word)
        {
            TrieNode current = root;
            for (int i = 0; i < word.Length; i++)
            {
                if (current.trieNodes[word[i] - 'a'] == null)
                    current.trieNodes[word[i] - 'a'] = new TrieNode();

                current = current.Next(word[i]);
            }
            current.terminating++;
        }

        /** Returns if the word is in the data structure. A word could contain the dot character '.' to represent any one letter. */
        public bool Search(string word)
        {
            return SearchHelper(word, root, 0);
        }

        private bool SearchHelper(string word, TrieNode currNode, int index)
        {
            if (index == word.Length)
                return currNode.terminating > 0;

            char ch = word[index];

            if (ch == '.')
            {
                for (int i = 0; i < 26; i++)
                {
                    if (currNode.trieNodes[i] != null && SearchHelper(word, currNode.trieNodes[i], index + 1))
                        return true;
                }
                return false;
            }
            else if (currNode.trieNodes[ch - 'a'] != null)
            {
                return SearchHelper(word, currNode.Next(ch), index + 1);
            }
            return false;
        }
    }
}
