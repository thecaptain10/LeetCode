using LeetCodeProblems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/path-sum-iii/
    //You are given a binary tree in which each node contains an integer value.Find the number of paths that sum to a given value.
    public class PathSumIII
    {
        public int PathSum(TreeNode root, int sum)
        {
            if (root == null)
                return 0;
            else
            {
                int count = helper(root, sum, 0);
                return count + PathSum(root.left, sum) + PathSum(root.right, sum);
            }
        }
        int helper(TreeNode root, int sum, int total)
        {
            if (root == null)
                return 0;
            else
            {
                total += root.val;
                int count = sum == total ? 1 : 0;
                count += helper(root.left, sum, total);
                count += helper(root.right, sum, total);
                return count;
            }
        }
    }
}
