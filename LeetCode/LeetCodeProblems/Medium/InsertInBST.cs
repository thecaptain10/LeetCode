using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/insert-into-a-binary-search-tree/
    //Given the root node of a binary search tree (BST) and a value to be inserted into the tree, insert the value into the BST. Return the root node of the BST after the insertion. It is guaranteed that the new value does not exist in the original BST.
    public class InsertInBST
    {
        public TreeNode InsertIntoBST(TreeNode root, int val)
        {
            if (root == null) return new TreeNode(val);

            if (root.val > val)
                root.left = InsertIntoBST(root.left, val);
            else
                root.right = InsertIntoBST(root.right, val);

            return root;
        }
    }
}
