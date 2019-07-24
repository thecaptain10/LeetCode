using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/kth-smallest-element-in-a-bst/
    //Given a binary search tree, write a function kthSmallest to find the kth smallest element in it.
    public class KthSmallestInBST
    {
        List<int> inorder = new List<int>();
        public int KthSmallest(TreeNode root, int k)
        {
            //Do Inorder as it returns sorted array.
            Inorder(root);
            //return k-1 th element.
            return inorder[k - 1];
        }

        public void Inorder(TreeNode root)
        {
            if (root == null)
                return;
            Inorder(root.left);
            inorder.Add(root.val);
            Inorder(root.right);
        }
    }
}
