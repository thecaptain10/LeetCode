using LeetCodeProblems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/
    public class ConvertSortedArrayToBST
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            TreeNode root = null;

            if (nums == null || nums.Count() == 0)
            {
                return root;
            }
            int length = nums.Count();

            root = new TreeNode(nums[length / 2]);

            //Take 0 to mid for left
            root.left = SortedArrayToBST(nums.Take(length / 2).ToArray());
            //Take mid+1 to end for right.
            root.right = SortedArrayToBST(nums.Skip(length / 2 + 1).Take(length - (length / 2 + 1)).ToArray());

            return root;
        }

    }
      
    
}
