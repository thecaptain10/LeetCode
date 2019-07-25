using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/maximum-width-of-binary-tree/
    //Given a binary tree, write a function to get the maximum width of the given tree. The width of a tree is the maximum width among all levels. The binary tree has the same structure as a full binary tree, but some nodes are null.
    //The width of one level is defined as the length between the end-nodes (the leftmost and right most non-null nodes in the level, where the null nodes between the end-nodes are also counted into the length calculation.
    public class MaxWidthOfBinaryTree
    {
        public int WidthOfBinaryTree(TreeNode root)
        {
            //Idea is to traverse level order and while traversing assign a position to each node.
            //If we go down the left neighbor, then position -> position * 2; and if we go down the right neighbor, then position -> position * 2 + 1. 
            //This makes it so that when we look at the position values L and R of two nodes with the same depth, the width will be R - L + 1.
            //We can use val to store position as val is not needed otherwise.
            if (root == null)
                return 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            //Assign root as position 1.
            root.val = 1;
            var max = 1;

            while (queue.Count != 0)
            {
                int size = queue.Count;
                max = Math.Max(max, queue.LastOrDefault().val - queue.Peek().val + 1);
                for (int i = 0; i < size; i++)
                {
                    TreeNode top = queue.Dequeue();
                    if (top.left != null)
                    {
                        top.left.val = top.val * 2;
                        queue.Enqueue(top.left);
                    }

                    if (top.right != null)
                    {
                        top.right.val = top.val * 2 + 1;
                        queue.Enqueue(top.right);
                    }
                }
            }

            return max;
        }
    }
}
