using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/sum-root-to-leaf-numbers/
    /*
        Given a binary tree containing digits from 0-9 only, each root-to-leaf path could represent a number.

        An example is the root-to-leaf path 1->2->3 which represents the number 123.

        Find the total sum of all root-to-leaf numbers.
    */
    public class SumRootToLeafNumbers
    {
        public int SumNumbers(TreeNode root)
        {
            return SumNumbersHelper(root, 0);
        }
        public int SumNumbersHelper(TreeNode root, int val)
        {
            if (root == null)
                return 0;
            //Update val.
            val = val * 10 + root.val;
            //If Leaf Node, return val.
            if (root.left == null && root.right == null)
            {
                return val;
            }
            return SumNumbersHelper(root.left, val) + SumNumbersHelper(root.right, val);
        }
    }
}
