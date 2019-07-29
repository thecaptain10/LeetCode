using LeetCodeProblems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/sum-of-root-to-leaf-binary-numbers/
    //Given a binary tree, each node has value 0 or 1.  Each root-to-leaf path represents a binary number starting with the most significant bit.  For example, if the path is 0 -> 1 -> 1 -> 0 -> 1, then this could represent 01101 in binary, which is 13.For all leaves in the tree, consider the numbers represented by the path from the root to that leaf. Return the sum of these numbers.
    public class RootToLeafBinaryNumbers
    {
        public int SumRootToLeaf(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            return TraverseTree(root, "", 0);
        }

        public int TraverseTree(TreeNode node, string str, int sum)
        {
            str += node.val;
            if (node.left != null)
            {
                sum = TraverseTree(node.left, str, sum);
            }
            if (node.right != null)
            {
                sum = TraverseTree(node.right, str, sum);
            }
            if (node.left == null && node.right == null)
            {
                return sum + Convert.ToInt32(str, 2);
            }
            return sum;
        }
    }
}
