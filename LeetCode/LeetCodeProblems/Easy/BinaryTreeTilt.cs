using LeetCodeProblems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/binary-tree-tilt/
    //Given a binary tree, return the tilt of the whole tree.The tilt of a tree node is defined as the absolute difference between the sum of all left subtree node values and the sum of all right subtree node values.Null node has tilt 0.
    public class BinaryTreeTilt
    {
        private int tiltSum;
        public int FindTilt(TreeNode root)
        {
            if (root == null)
                return 0;
            Sum(root);
            return tiltSum;
        }

        private int Sum(TreeNode node)
        {
            if (node == null)
                return 0;
            int left = Sum(node.left);
            int right = Sum(node.right);

            tiltSum += Math.Abs(left - right);

            return node.val + left + right;
        }
    }
}
