using LeetCodeProblems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Hard
{
    //https://leetcode.com/problems/binary-tree-maximum-path-sum/
    /*
     Given a non-empty binary tree, find the maximum path sum.
    */
    public class MaximumSumPath
    {
        private long res = int.MinValue;
        public int MaxPathSum(TreeNode root)
        {
            MaxPathSumHelper(root);
            return (int)res;
        }

        private long MaxPathSumHelper(TreeNode root)
        {
            if (root == null) return 0;

            var left = MaxPathSumHelper(root.left);
            var right = MaxPathSumHelper(root.right);


            //Max path sum through current node as root. 3 cases arise
            //Just node value.
            // node value + left 
            // node value + right
            var pathThroughRoot = Math.Max(Math.Max(left, right) + root.val, root.val);

            //If Max Sum Path does not go through root, keep storing Max sum in global variable.
            res = Math.Max(res, Math.Max(pathThroughRoot, left + right + root.val));

            //return max sum for this node as root.
            return pathThroughRoot;
        }
    }
}
