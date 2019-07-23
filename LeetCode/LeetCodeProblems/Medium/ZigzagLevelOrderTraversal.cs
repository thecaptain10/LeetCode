using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal/
    //Given a binary tree, return the zigzag level order traversal of its nodes' values. (ie, from left to right, then right to left for the next level and alternate between).
    public class ZigzagLevelOrderTraversal
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            IList<IList<int>> res = new List<IList<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            Queue<TreeNode> nextqueue = new Queue<TreeNode>();
            queue.Enqueue(root);
            //Variable to Flip Direction after each level.
            bool leftToRight = true;
            while (queue.Any())
            {
                int size = queue.Count;
                List<int> oneLevelNode = new List<int>();
                //For Each Level
                for (int i = 0; i < size; i++)
                {
                    TreeNode top = queue.Dequeue();
                    if (top == null) continue;
                    oneLevelNode.Add(top.val);

                    //Insert Left and then Right Tree.
                    nextqueue.Enqueue(top.left);
                    nextqueue.Enqueue(top.right);
                }
                foreach (var node in nextqueue)
                {
                    queue.Enqueue(node);
                }
                nextqueue.Clear();

                if (!leftToRight)
                {
                    oneLevelNode.Reverse();
                }
                //Flip Direction
                leftToRight = !leftToRight;
                if (oneLevelNode.Any())
                {
                    res.Add(oneLevelNode);
                }
            }
            return res;
        }
    }
}
