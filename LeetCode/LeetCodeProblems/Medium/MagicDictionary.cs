using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    public class MagicDictionary
    {
        TrieNode root;

        public MagicDictionary()
        {
            root = new TrieNode();
        }



        /** Build a dictionary through a list of words */
        public void BuildDict(string[] dict)
        {
            foreach (string word in dict)
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

        }

        /** Returns if there is any word in the trie that equals to the given word after modifying exactly one character */
        public bool Search(string word)
        {
            //Brute Force
            // Replace one char at each index skipping same char which is already present
            //if any of the formed word is present in Trie. Return.
            StringBuilder searchWord = new StringBuilder(word);

            for (int i = 0; i < word.Length; i++)
            {
                char ch = word[i];

                for (char c = 'a'; c <= 'z'; c++)
                {
                    if (c == ch)
                        continue;

                    searchWord[i] = c;

                    if (IsPresent(searchWord.ToString()))
                        return true;
                }

                searchWord[i] = ch;
            }
            return false;
        }

        public bool IsPresent(string word)
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
    }
}
