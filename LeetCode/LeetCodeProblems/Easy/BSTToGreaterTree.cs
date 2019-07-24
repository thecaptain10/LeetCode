using LeetCodeProblems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/convert-bst-to-greater-tree/
    //Given a Binary Search Tree (BST), convert it to a Greater Tree such that every key of the original BST is changed to the original key plus sum of all keys greater than the original key in BST.
    public class BSTToGreaterTree
    {
        public TreeNode ConvertBST(TreeNode root)
        {
            Helper(root, 0);
            return root;
        }

        public int Helper(TreeNode root, int sum)
        {
            if (root == null)
            {
                return sum;
            }

            root.val += Helper(root.right, sum);
            return Helper(root.left, root.val);
        }
    }
}
