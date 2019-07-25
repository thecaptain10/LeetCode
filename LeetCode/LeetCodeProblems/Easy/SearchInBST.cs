using LeetCodeProblems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/search-in-a-binary-search-tree/
    //Given the root node of a binary search tree (BST) and a value. You need to find the node in the BST that the node's value equals the given value. Return the subtree rooted with that node. If such node doesn't exist, you should return NULL.
    public class SearchInBST
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null)
                return null;

            if (root.val == val)
                return root;
            else if (root.val < val)
                return SearchBST(root.right, val);
            else
                return SearchBST(root.left, val);

        }
    }
}
