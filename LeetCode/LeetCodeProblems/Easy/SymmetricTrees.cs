using LeetCodeProblems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/symmetric-tree/
    //Given a binary tree, check whether it is a mirror of itself (ie, symmetric around its center).
    class SymmetricTrees
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null)
                return true;

            return AreMirror(root, root);
        }

        public bool AreMirror(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null)
                return true;

            if (root1 != null && root2 != null && (root1.val == root2.val))
            {
                return (AreMirror(root1.left, root2.right) && AreMirror(root1.right, root2.left));
            }

            return false;
        }
    }
}
