using LeetCodeProblems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/same-tree/
    //Given two binary trees, write a function to check if they are the same or not.Two binary trees are considered the same if they are structurally identical and the nodes have the same value.
    public class SameTree
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {

            if (p == null && q == null)
                return true;

            if ((p != null && q != null) && (p.val == q.val))
            {
                return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
            }

            return false;

        }
    }
}
