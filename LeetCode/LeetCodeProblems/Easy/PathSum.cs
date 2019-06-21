using LeetCodeProblems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/path-sum/
    public class PathSum
    {
        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null)
                return false;
            if (root.val == sum && (root.left == null && root.right == null))
                return true;

            return HasPathSum(root.right, sum - root.val) || HasPathSum(root.left, sum - root.val);
        }
    }
}
