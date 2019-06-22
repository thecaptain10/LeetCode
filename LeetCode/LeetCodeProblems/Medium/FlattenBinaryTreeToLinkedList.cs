using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/flatten-binary-tree-to-linked-list/
    //Given a binary tree, flatten it to a linked list in-place.
    public class FlattenBinaryTreeToLinkedList
    {
        public void Flatten(TreeNode root)
        {
            if (root == null) return;
            var left = root.left;
            var right = root.right;

            root.left = null;
            Flatten(left);
            Flatten(right);

            root.right = left;
            TreeNode current = root;
            while (current.right != null) current = current.right;

            current.right = right;
        }
    }
}
