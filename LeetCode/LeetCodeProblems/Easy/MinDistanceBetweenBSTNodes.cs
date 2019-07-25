using LeetCodeProblems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/minimum-distance-between-bst-nodes/
    //Given a Binary Search Tree (BST) with the root node root, return the minimum difference between the values of any two different nodes in the tree.
    public class MinDistanceBetweenBSTNodes
    {
        //Get the rightmost child of your left child and the leftmost child of your right child because those values would be the closest to your current node's value and then get the small diff.
        int min = int.MaxValue;
        public int MinDiffInBST(TreeNode root)
        {
            FindMin(root);
            return min;
        }

        public void FindMin(TreeNode root)
        {
            if (root.left == null && root.right == null)
                return;
            if (root.left != null)
            {
                int m = root.val - GetRightMost(root.left);
                if (m < min)
                    min = m;
                FindMin(root.left);
            }
            if (root.right != null)
            {
                int m = GetLeftMost(root.right) - root.val;
                if (m < min)
                    min = m;
                FindMin(root.right);
            }
        }

        public int GetLeftMost(TreeNode root)
        {
            if (root.left == null)
                return root.val;
            return GetLeftMost(root.left);
        }
        public int GetRightMost(TreeNode root)
        {
            if (root.right == null)
                return root.val;
            return GetRightMost(root.right);
        }
    }
}
