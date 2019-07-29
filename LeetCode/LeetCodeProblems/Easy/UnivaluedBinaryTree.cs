using LeetCodeProblems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/univalued-binary-tree/
    //A binary tree is univalued if every node in the tree has the same value.Return true if and only if the given tree is univalued.
    public class UnivaluedBinaryTree
    {
        public bool IsUnivalTree(TreeNode root)
        {
            if (root == null)
                return true;

            if ((root.left != null && root.val != root.left.val) ||
              root.right != null && root.val != root.right.val)
                return false;

            return (IsUnivalTree(root.left) && IsUnivalTree(root.right));
        }
    }
}
