using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree/
    //Given a binary tree, find the lowest common ancestor (LCA) of two given nodes in the tree.
    public class LowestCommonAncestorInBinaryTree
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            List<TreeNode> pPath = new List<TreeNode>();
            List<TreeNode> qPath = new List<TreeNode>();

            if (!FindPath(root, p, pPath) || !FindPath(root, q, qPath))
                return null;

            //Once we have path for both nodes. compare path. when we find first mismatch element at previous index in LCA
            int i = 0;
            for (i = 0; i < pPath.Count && i < qPath.Count; i++)
            {
                if (pPath[i] != qPath[i])
                    break;
            }
            return pPath[i - 1];
        }

        public bool FindPath(TreeNode root, TreeNode node, List<TreeNode> path)
        {
            //Get Path from root till node.
            if (root == null)
                return false;

            path.Add(root);

            if (root.val == node.val)
                return true;

            if (FindPath(root.left, node, path) || FindPath(root.right, node, path))
                return true;

            //if node is not in both left and right tree, then remove it from Path.
            path.RemoveAt(path.Count - 1);
            return false;
        }
    }
}
