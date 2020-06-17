using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{

    //https://leetcode.com/problems/camelcase-matching/
    //A query word matches a given pattern if we can insert lowercase letters to the pattern word so that it equals the query. (We may insert each character at any position, and may insert 0 characters.)
    //Given a list of queries, and a pattern, return an answer list of booleans, where answer[i] is true if and only if queries[i] matches the pattern
    public class TrieNodeWithUpperCaseLetters
    {
        public bool isLeaf;
        public List<string> words;
        public TrieNodeWithUpperCaseLetters [] trieNodes = new TrieNodeWithUpperCaseLetters[26];

        public TrieNodeWithUpperCaseLetters()
        {
            isLeaf = false;
            words = new List<string>();
        }

        public TrieNodeWithUpperCaseLetters Next(char ch)
        {
            return this.trieNodes[ch - 'A'];
        }
    }

    public class TrieWithUpperCaseLetters
    {
        TrieNodeWithUpperCaseLetters root;

        public TrieWithUpperCaseLetters()
        {
            root = new TrieNodeWithUpperCaseLetters();
        }

        public void Insert(string word)
        {
            TrieNodeWithUpperCaseLetters current = root;

            for(int i = 0; i < word.Length; i++)
            {
                if (char.IsLower(word[i]))
                    continue;

                if (current.trieNodes[word[i] - 'A'] == null)
                    current.trieNodes[word[i] - 'A'] = new TrieNodeWithUpperCaseLetters();

                current = current.trieNodes[word[i] - 'A'];
            }

            if (!current.words.Contains(word))
                current.words.Add(word);
            current.isLeaf = true;
        }

        public TrieNodeWithUpperCaseLetters GetPrefixNode(string word)
        {
            TrieNodeWithUpperCaseLetters current = root;

            for (int i = 0; i < word.Length; i++)
            {

                if (current.trieNodes[word[i] - 'A'] == null)
                    return null;

                current = current.trieNodes[word[i] - 'A'];
            }
            return current;
        }

        
    }

    public class CamelcaseMatching
    {

        //Works as long as Pattern contains only Upper Case Letters.Will check Later.
        //public IList<bool> CamelMatch(string[] queries, string pattern)
        //{         
        //    IList<bool> result = new List<bool>();

        //    //Create Trie
        //    TrieWithUpperCaseLetters trie = new TrieWithUpperCaseLetters();

        //    //Store all Captial Letters of queries in Trie.
        //    foreach (string query in queries)
        //        trie.Insert(query);

        //    //Get Prefix Node
        //    TrieNodeWithUpperCaseLetters prefixNode = trie.GetPrefixNode(pattern);

        //    foreach (string query in queries)
        //    {
        //        if (prefixNode.words.Contains(query))
        //            result.Add(true);
        //        else
        //            result.Add(false);

        //    }

        //    return result;
        //}

        public IList<bool> CamelMatch(string[] queries, string pattern)
        {

            IList<bool> res = new List<bool>();

            foreach (string query in queries)
            {
                bool isPossible = true;
                int i = 0;
                int pi = 0;

                while (i < query.Length)
                {
                    if (pi < pattern.Length && pattern[pi] == query[i])
                    {
                        pi++;
                    }
                    else if (char.IsUpper(query[i]))
                    {
                        isPossible = false;
                        break;
                    }
                    i++;
                }

                res.Add(isPossible && pi == pattern.Length);

            }

            return res;
        }



    }
}
