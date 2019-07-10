using LeetCodeProblems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/
    //Lowest Common Ancestor of a Binary Search Tree
    public class LowestCommonAncestorInBST
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null)
                return null;
            //if both values are smaller, check in left subtree.
            //if both values are greater, check in right subtree
            //else return root.
            if (root.val < p.val && root.val < q.val)
                return LowestCommonAncestor(root.right, p, q);
            else if (root.val > p.val && root.val > q.val)
                return LowestCommonAncestor(root.left, p, q);

            return root;
        }
    }
}
