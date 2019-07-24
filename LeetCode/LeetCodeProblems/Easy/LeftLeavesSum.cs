using LeetCodeProblems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/sum-of-left-leaves/
    //Find the sum of all left leaves in a given binary tree.
    public class LeftLeavesSum
    {
        public int SumOfLeftLeaves(TreeNode root)
        {
            int sum = 0;
            if (root == null)
                return 0;
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

                    //Check for left leaf
                    if (top.left != null && top.left.left == null && top.left.right == null)
                    {
                        sum += top.left.val;
                    }
                    //Insert Left and then Right Tree.
                    if (top.left != null)
                        queue.Enqueue(top.left);
                    if (top.right != null)
                        queue.Enqueue(top.right);
                }
            }
            return sum;
        }
    }
}
