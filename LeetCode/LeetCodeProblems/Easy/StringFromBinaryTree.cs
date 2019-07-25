using LeetCodeProblems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/construct-string-from-binary-tree/
    //You need to construct a string consists of parenthesis and integers from a binary tree with the preorder traversing way.The null node needs to be represented by empty parenthesis pair "()". And you need to omit all the empty parenthesis pairs that don't affect the one-to-one mapping relationship between the string and the original binary tree.
    public class StringFromBinaryTree
    {
        private StringBuilder output = new StringBuilder();
        public string Tree2str(TreeNode t)
        {
            Traverse(t);
            return output.ToString();
        }

        public void Traverse(TreeNode t)
        {
            if (t == null) return;
            output.Append(t.val);

            if (t.left != null || t.right != null)
            {
                output.Append("(");
                Traverse(t.left);
                output.Append(")");
            }

            if (t.right != null)
            {
                output.Append("(");
                Traverse(t.right);
                output.Append(")");
            }
        }
    }
}
