using LeetCodeProblems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/invert-binary-tree/
    //Invert a binary tree.
    public class InvertBinaryTree
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return null;

            TreeNode temp = null;

            //Swap Left and Right Child of Root
            temp = root.right;
            root.right = root.left;
            root.left = temp;

            //Invert Left SubTree.
            InvertTree(root.left);
            //Invert Right SubTree.
            InvertTree(root.right);

            return root;
        }
    }
}
