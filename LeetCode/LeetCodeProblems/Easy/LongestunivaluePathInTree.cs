using LeetCodeProblems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/longest-univalue-path/
    //Given a binary tree, find the length of the longest path where each node in the path has the same value. This path may or may not pass through the root.
    public class LongestunivaluePathInTree
    {
        int res = 0;
        public int LongestUnivaluePath(TreeNode root)
        {

            MaxLength(root);
            return res;
        }
        public int MaxLength(TreeNode root)
        {
            if (root == null)
                return 0;

            int left = MaxLength(root.left);
            int right = MaxLength(root.right);

            int maxLeft = 0;
            int maxRight = 0;

            if (root.left != null && root.left.val == root.val)
                maxLeft += 1 + left;

            if (root.right != null && root.right.val == root.val)
                maxRight += 1 + right;

            res = Math.Max(res, maxLeft + maxRight);

            return Math.Max(maxLeft, maxRight);
        }
    }
}
