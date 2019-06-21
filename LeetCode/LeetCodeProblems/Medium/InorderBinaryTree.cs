using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    public class InorderBinaryTree
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> res = new List<int>();
            Stack<TreeNode> stack = new Stack<TreeNode>();

            if (root == null)
                return res;

            TreeNode node = root;

            while (stack.Any() || node != null)
            {
                if (node != null)
                {
                    stack.Push(node);
                    node = node.left;
                }
                else
                {
                    TreeNode temp = stack.Pop();
                    res.Add(temp.val);
                    node = temp.right;
                }
            }
            return res;
        }
    }
}
