using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/construct-binary-tree-from-inorder-and-postorder-traversal/
    //Construct Binary Tree from Inorder and Postorder Traversal
    public class BinaryTreeFromInorderAndPostorder
    {        
        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            //PostOrder = Left -> Right -> Root
            //Inorder = Left -> Root -> Right
            
            int inStart = 0;
            int inEnd = inorder.Length-1;
            int postStart = 0;
            int postEnd = postorder.Length-1;

            return BuildTreeHelper(inorder, inStart, inEnd, postorder, postStart, postEnd);

        }

        public TreeNode BuildTreeHelper(int[] inorder, int inStart, int inEnd, int[] postorder, int postStart, int postEnd)
        {
            if (inStart > inEnd || postStart > postEnd)
                return null;
            // Last Element of PostOrder is Root.
            int rootValue = postorder[postEnd];
            TreeNode root = new TreeNode(postorder[postEnd]);

            //Find root index in inorder.
            int inorderRootIndex = Array.IndexOf(inorder, rootValue);

            root.left = BuildTreeHelper(inorder, inStart, inorderRootIndex - 1, postorder, postStart, postStart + inorderRootIndex - (inStart + 1));
            root.right = BuildTreeHelper(inorder, inorderRootIndex+1, inEnd, postorder, postStart + inorderRootIndex - inStart, postEnd-1);

            return root;
        }
    }
}
