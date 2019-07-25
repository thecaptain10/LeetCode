using LeetCodeProblems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/second-minimum-node-in-a-binary-tree/
    //Second Minimum Node In a Binary Tree
    public class SecondMinInBinaryTree
    {
        public int FindSecondMinimumValue(TreeNode root)
        {
            if (root == null || root.left == null || root.right == null) return -1;

            int l = root.left.val;
            if (root.val == l)
                l = FindSecondMinimumValue(root.left);

            int r = root.right.val;
            if (root.val == r)
                r = FindSecondMinimumValue(root.right);

            if (l == -1) return r;
            else if (r == -1) return l;
            return Math.Min(l, r);
        }
    }
}
