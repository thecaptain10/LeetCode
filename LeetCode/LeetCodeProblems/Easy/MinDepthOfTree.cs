using LeetCodeProblems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/minimum-depth-of-binary-tree/
    //Minimum Depth of Binary Tree
    public class MinDepthOfTree
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            //Leaf Node
            if (root.left == null && root.right == null)
            {
                return 1;
            }

            // If left subtree is NULL, recur for right subtree  
            if (root.left == null)
            {
                return MinDepth(root.right) + 1;
            }

            // If right subtree is NULL, recur for left subtree  
            if (root.right == null)
            {
                return MinDepth(root.left) + 1;
            }

            return Math.Min(MinDepth(root.left), MinDepth(root.right)) + 1;

        }
    }
}
