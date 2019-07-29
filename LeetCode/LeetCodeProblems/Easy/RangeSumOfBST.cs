using LeetCodeProblems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/range-sum-of-bst/
    //Given the root node of a binary search tree, return the sum of values of all nodes with value between L and R (inclusive).
    public class RangeSumOfBST
    {
        int sum = 0;
        public int RangeSumBST(TreeNode root, int L, int R)
        {
            RangeSumBSTHelper(root, L, R);
            return sum;
        }

        public void RangeSumBSTHelper(TreeNode root, int L, int R)
        {
            if (root == null)
                return;

            if (root.val >= L && root.val <= R)
                sum += root.val;

            RangeSumBSTHelper(root.left, L, R);
            RangeSumBSTHelper(root.right, L, R);
        }
    }
}
