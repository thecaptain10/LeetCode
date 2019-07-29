using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/flip-equivalent-binary-trees/
    //For a binary tree T, we can define a flip operation as follows: choose any node, and swap the left and right child subtrees.Write a function that determines whether two binary trees are flip equivalent. 
    public class FlipEquivalentBinaryTree
    {
        public bool FlipEquiv(TreeNode root1, TreeNode root2)
        {
            if (root1 == root2)
                return true;

            //if root1 and root2 have different values, they aren't equivalent.
            if (root1 == null || root2 == null || root1.val != root2.val)
                return false;

            //children of root1 are equivalent to the children of root2. There are two different ways to pair these children.
            return (FlipEquiv(root1.left, root2.left) && FlipEquiv(root1.right, root2.right) ||
                    FlipEquiv(root1.left, root2.right) && FlipEquiv(root1.right, root2.left));
        }
    }
}
