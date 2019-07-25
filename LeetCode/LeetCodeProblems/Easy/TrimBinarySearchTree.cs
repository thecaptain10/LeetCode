using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/trim-a-binary-search-tree/
    //Given a binary search tree and the lowest and highest boundaries as L and R, trim the tree so that all its elements lies in [L, R] (R >= L). You might need to change the root of the tree, so the result should return the new root of the trimmed binary search tree.
    public class TrimBinarySearchTree
    {
        public TreeNode TrimBST(TreeNode root, int L, int R)
        {
            if (root == null)
                return null;

            //Trim Left sub Tree if root value < L
            if (root.val < L)
                return TrimBST(root.right, L, R);

            //Trim Right sub Tree if root value > R
            if (root.val > R)
                return TrimBST(root.left, L, R);

            //Recur for both left and right subtree.
            root.left = TrimBST(root.left, L, R);

            root.right = TrimBST(root.right, L, R);

            return root;
        }
    }
}
