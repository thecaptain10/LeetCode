using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/n-ary-tree-preorder-traversal/
    //Given an n-ary tree, return the preorder traversal of its nodes' values.
    public class N_AryPreOrderTraversal
    {
        IList<int> res = new List<int>();
        public IList<int> Preorder(Node root)
        {
            PreOrderHelper(root);
            return res;
        }

        public void PreOrderHelper(Node root)
        {
            if (root == null)
                return;
            //first root, then children visit.
            res.Add(root.val);
            foreach (Node node in root.children)
                PreOrderHelper(node);
        }
    }
}
