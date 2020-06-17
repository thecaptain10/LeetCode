using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/replace-words/
    //In English, we have a concept called root, which can be followed by some other words to form another longer word - let's call this word successor. For example, the root an, followed by other, which can form another word another.
    //Now, given a dictionary consisting of many roots and a sentence.You need to replace all the successor in the sentence with the root forming it.If a successor has many roots can form it, replace it with the root with the shortest length.
    public class TrieNodeWithWord
    {
        public string Word { get; set; }

        public TrieNodeWithWord[] trieNodes = new TrieNodeWithWord[26];

        public TrieNodeWithWord Next(char c)
        {
            return this.trieNodes[c - 'a'];
        }

    }
    public class TrieWithWord
    {
        public TrieNodeWithWord root;

        public TrieWithWord()
        {
            this.root = new TrieNodeWithWord();
        }

        /** Inserts a word into the trie. */
        public void Insert(string word)
        {
            TrieNodeWithWord current = root;
            for (int i = 0; i < word.Length; i++)
            {
                if (current.trieNodes[word[i] - 'a'] == null)
                    current.trieNodes[word[i] - 'a'] = new TrieNodeWithWord();

                current = current.Next(word[i]);
            }
            current.Word = word;
        }

    }
    public class ReplaceWordsWithRoot
    {
        public StringBuilder res = new StringBuilder();

        public string ReplaceWords(IList<string> dict, string sentence)
        {
            TrieWithWord trieWithWord = new TrieWithWord();

            foreach (string item in dict)
                trieWithWord.Insert(item);


            foreach (string word in sentence.Split(' ').ToList())
                ReplaceIfSuccessor(word, trieWithWord.root);


            return res.ToString().Trim();
        }

        private void ReplaceIfSuccessor(string word, TrieNodeWithWord root)
        {
            bool isRootWordFound = false;

            TrieNodeWithWord current = root;
            for(int i=0;i<word.Length;i++)
            {
                char ch = word[i];

                
                if(!string.IsNullOrEmpty(current.Word))
                {
                    isRootWordFound = true;
                    break;
                }

                if (current.trieNodes[ch - 'a'] == null)
                    break;

                current = current.Next(ch);

            }

            if (isRootWordFound)
                res.Append(" " + current.Word);
            else
                res.Append(" " + word);
        }
    }
}
