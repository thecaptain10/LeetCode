using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/construct-binary-search-tree-from-preorder-traversal/
    //Construct Binary Search Tree from Preorder Traversal
    public class ConstructBSTFromPreOrder
    {
        public TreeNode BstFromPreorder(int[] preorder)
        {
            if (preorder == null)
                return null;
            // first node in preorder traversal will be root.
            TreeNode root = new TreeNode(preorder[0]);

            // Insert all elements in bst pattern		
            for (int i = 1; i < preorder.Length; i++)
                InsertInBST(root, preorder[i]);

            return root;
        }

        private void InsertInBST(TreeNode root, int val)
        {
            TreeNode current = root;
            TreeNode parent = null;
            while (current != null)
            {
                parent = current;
                current = current.val > val ? current.left : current.right;
            }

            if (parent.val > val)
                parent.left = new TreeNode(val);
            else
                parent.right = new TreeNode(val);
        }
    }
}
