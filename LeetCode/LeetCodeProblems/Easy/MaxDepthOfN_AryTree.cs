using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }
        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }
    //https://leetcode.com/problems/maximum-depth-of-n-ary-tree/
    //Given a n-ary tree, find its maximum depth
    public class MaxDepthOfN_AryTree
    {
        public int MaxDepth(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            if (root.children == null || root.children.Count == 0)
            {
                return 1;
            }
            List<int> list = new List<int>();
            foreach (Node child in root.children)
            {
                list.Add(MaxDepth(child));
            }
            return list.Max() + 1;
        }
    }
}
