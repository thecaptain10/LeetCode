using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/binary-tree-level-order-traversal/
    //Given a binary tree, return the level order traversal of its nodes' values. (ie, from left to right, level by level).
    public class LevelOrderTraversal
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> res = new List<IList<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
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
                    queue.Enqueue(top.left);
                    queue.Enqueue(top.right);
                }
                if (oneLevelNode.Any())
                {
                    res.Add(oneLevelNode);
                }
            }
            return res;
        }
    }
}
