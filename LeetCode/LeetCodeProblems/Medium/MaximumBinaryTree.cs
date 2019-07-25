using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/maximum-binary-tree/
    //Construct the maximum tree by the given array and output the root node of this tree.
    public class MaximumBinaryTree
    {
        public TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            return ConstructMaximumBinaryTreeHelper(nums, 0, nums.Length - 1);
        }
        private TreeNode ConstructMaximumBinaryTreeHelper(int[] nums, int start, int end)
        {
            if (start > end) return null;
            if (start == end)
            {
                return new TreeNode(nums[start]);
            }
            //Find Index of Maxinum element.
            int maxIndex = 0;
            int max = int.MinValue;
            for (int i = start; i <= end; i++)
                if (nums[i] > max)
                {
                    max = nums[i];
                    maxIndex = i;
                }

            TreeNode root = new TreeNode(nums[maxIndex]);
            root.left = ConstructMaximumBinaryTreeHelper(nums, start, maxIndex - 1);
            root.right = ConstructMaximumBinaryTreeHelper(nums, maxIndex + 1, end);

            return root;
        }

    }
}
