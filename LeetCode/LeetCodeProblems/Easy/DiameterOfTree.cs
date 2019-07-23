using LeetCodeProblems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/diameter-of-binary-tree/
    //Given a binary tree, you need to compute the length of the diameter of the tree. The diameter of a binary tree is the length of the longest path between any two nodes in a tree. This path may or may not pass through the root.
    //O(n2)
    public class DiameterOfTree
    {
        public int DiameterOfBinaryTree(TreeNode root)
        {
            if (root == null)
                return 0;

            //Calculate Height of Left and Right Tree
            int lHeight = Height(root.left);
            int rHeight = Height(root.right);

            //Calculate Diameter recursively for left and right tree
            int lDiameter = DiameterOfBinaryTree(root.left);
            int rDiameter = DiameterOfBinaryTree(root.right);

            //Return Max of :      
            // Diameter of left subtree // Longest Path entirely in left subtree
            // Diameter of right subtree  // Longest Path entirely in right subtree
            // Height of left subtree + height of right subtree
            return Math.Max((lHeight + rHeight), Math.Max(lDiameter, rDiameter));
        }

        public int Height(TreeNode root)
        {
            if (root == null)
                return 0;
            return 1 + Math.Max(Height(root.left), Height(root.right));
        }
    }
}
