using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    //https://leetcode.com/problems/binary-tree-preorder-traversal/
    //PreOrder : parent->left->rigth;
    public class PreOrderBinaryTree
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            IList<int> res = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();

            if (root == null)
                return res;

            stack.Push(root);

            while(stack.Any())
            {
                TreeNode node = stack.Pop();
                res.Add(node.val);

                //Push Right First as stack.
                if (node.right != null)
                    stack.Push(node.right);

                if (node.left != null)
                    stack.Push(node.left);
            }
            return res;
        }
    }
}
