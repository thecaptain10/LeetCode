using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/binary-search-tree-iterator/
    //Implement an iterator over a binary search tree (BST). Your iterator will be initialized with the root node of a BST.Calling next() will return the next smallest number in the BST.
    public class BSTIterator
    {

        Stack<TreeNode> stack = new Stack<TreeNode>();
        public BSTIterator(TreeNode root)
        {
            pushToLeft(root);
        }

        /** @return the next smallest number */
        public int Next()
        {
            TreeNode node = stack.Pop();
            pushToLeft(node.right);
            return node.val;
        }

        /** @return whether we have a next smallest number */
        public bool HasNext()
        {
            if (stack.Count == 0)
            {
                return false;
            }
            return true;
        }

        private void pushToLeft(TreeNode node)
        {
            if (node != null)
            {
                stack.Push(node);
                pushToLeft(node.left);
            }
        }
    }

    /**
     * Your BSTIterator object will be instantiated and called as such:
     * BSTIterator obj = new BSTIterator(root);
     * int param_1 = obj.Next();
     * bool param_2 = obj.HasNext();
     */
}
