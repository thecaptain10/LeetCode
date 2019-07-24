using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/find-bottom-left-tree-value/
    //Given a binary tree, find the leftmost value in the last row of the tree.
    public class BottomLeftTreeValue
    {
        public int FindBottomLeftValue(TreeNode root)
        {
            //Do Level Order Traversal and add largest element of each level to result.
            int res = int.MinValue;
            if (root == null)
            {
                return res;
            }
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Any())
            {
                int size = queue.Count;            
                //For Each Level
                for (int i = 0; i < size; i++)
                {
                    TreeNode top = queue.Dequeue();
                    if (top == null) continue;

                    if (i == 0)
                        res = top.val;
                    //Insert Left and then Right Tree.
                    if (top.left != null)
                        queue.Enqueue(top.left);
                    if (top.right != null)
                        queue.Enqueue(top.right);
                }

            }
            return res;
        }
    }
}
