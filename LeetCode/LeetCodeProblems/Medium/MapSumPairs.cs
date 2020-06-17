using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/map-sum-pairs/
    //Implement a MapSum class with insert, and sum methods.
    //For the method insert, you'll be given a pair of (string, integer). The string represents the key and the integer represents the value. If the key already existed, then the original key-value pair will be overridden to the new one.
    //For the method sum, you'll be given a string representing the prefix, and you need to return the sum of all the pairs' value whose key starts with the prefix.
    
    public class MapSumTrieNode
    {
        //Store sum as well as word.
        public int sum;
        public string word;
        public MapSumTrieNode[] trieNodes = new MapSumTrieNode[26];

        public MapSumTrieNode Next(char c)
        {
            return this.trieNodes[c - 'a'];
        }

    }

    public class MapSumTrie
    {
        MapSumTrieNode root;

        public MapSumTrie()
        {
            root = new MapSumTrieNode();
        }

        public void Insert(string key, int val)
        {
            MapSumTrieNode current = root;

            for(int i = 0;i<key.Length;i++)
            {
                if (current.trieNodes[key[i] - 'a'] == null)
                    current.trieNodes[key[i] - 'a'] = new MapSumTrieNode();

                current = current.Next(key[i]);
            }
            current.word = key;
            current.sum = val;
        }

        public MapSumTrieNode GetPrefixNode(string prefix)
        {
            MapSumTrieNode current = root;

            for (int i = 0; i < prefix.Length; i++)
            {
                if (current.trieNodes[prefix[i] - 'a'] == null)
                    return null;

                current = current.Next(prefix[i]);
            }
            return current;
        }
    }


    public class MapSum
    {
        MapSumTrie MapSumTrie;

        public MapSum()
        {
            MapSumTrie = new MapSumTrie();   
        }


        public void Insert(string key, int val)
        {
            MapSumTrie.Insert(key, val);
        }

        public int Sum(string prefix)
        {            
            //GetPrefix Node
            MapSumTrieNode prefixNode = MapSumTrie.GetPrefixNode(prefix);

            //Get sum of all leaves.
            return MapSumHelper(prefixNode);

        }

        private int MapSumHelper(MapSumTrieNode node)
        {
            if (node == null)
                return 0;

            int sum = node.sum;

            foreach (MapSumTrieNode childNode in node.trieNodes)
                sum += MapSumHelper(childNode);

            return sum;
        }
    }
}
