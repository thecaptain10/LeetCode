using LeetCodeProblems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/balanced-binary-tree/
    //Given a binary tree, determine if it is height-balanced.
    public class BalancedBinaryTree
    {
        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
                return true;

            int lheight = Height(root.left);
            int rheight = Height(root.right);

            if (Math.Abs(lheight - rheight) <= 1 && IsBalanced(root.left)
                                        && IsBalanced(root.right))
            {
                return true;
            }

            return false;
        }

        public int Height(TreeNode root)
        {
            if (root == null)
                return 0;

            return 1 + Math.Max(Height(root.left), Height(root.right));
        }
    }
}
