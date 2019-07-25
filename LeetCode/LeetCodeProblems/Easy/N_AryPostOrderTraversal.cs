using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/n-ary-tree-postorder-traversal/
    //Given an n-ary tree, return the postorder traversal of its nodes' values.
    public class N_AryPostOrderTraversal
    {
        IList<int> res = new List<int>();
        public IList<int> Postorder(Node root)
        {
            PostOrderHelper(root);
            return res;
        }
        public void PostOrderHelper(Node root)
        {
            if (root == null)
                return;

            //First Children then root
            foreach (Node node in root.children)
                PostOrderHelper(node);

            res.Add(root.val);
        }
    }
}
