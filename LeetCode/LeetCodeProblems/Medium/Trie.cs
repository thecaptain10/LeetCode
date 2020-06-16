using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/implement-trie-prefix-tree/
    //Implement Trie (Prefix Tree)
    //Time Complexity : O(length of word) for all operations
    public class TrieNode
    {
        public int terminating;

        public TrieNode[] trieNodes = new TrieNode[26];

        public TrieNode Next(char c)
        {
            return this.trieNodes[c - 'a'];
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
            current.terminating++;
        }

        /** Returns if the word is in the trie. */
        public bool Search(string word)
        {
            TrieNode current = root;
            for (int i = 0; i < word.Length; i++)
            {
                if (current.trieNodes[word[i] - 'a'] == null)
                    return false;

                current = current.Next(word[i]);
            }

            if (current.terminating > 0)
                return true;

            return false;
        }

        /** Returns if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith(string prefix)
        {
            TrieNode current = root;
            for (int i = 0; i < prefix.Length; i++)
            {
                if (current.trieNodes[prefix[i] - 'a'] == null)
                    return false;

                current = current.Next(prefix[i]);
            }
            
            if(current != null || current.terminating > 0)
                return true;

            return false;

        }

    }
}
