using LeetCodeProblems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/minimum-absolute-difference-in-bst/
    //Given a binary search tree with non-negative values, find the minimum absolute difference between values of any two nodes.
    public class MinAbsoluteDiffInBST
    {
        int minabs = int.MaxValue;
        int prev = int.MaxValue;

        public int GetMinimumDifference(TreeNode root)
        {           
            //Inorder Traversal will yield sorted list, just keep checking with prev value. 
            if (root == null)
                return 0;

            GetMinimumDifference(root.left);

            if (Math.Abs(prev - root.val) < Math.Abs(minabs))
                minabs = Math.Abs(prev - root.val);
            prev = root.val;

            GetMinimumDifference(root.right);

            return minabs;
        }
    }
}
