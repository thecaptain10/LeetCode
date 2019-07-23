using LeetCodeProblems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/binary-tree-level-order-traversal-ii/
    //Given a binary tree, return the bottom-up level order traversal of its nodes' values. (ie, from left to right, level by level from leaf to root).
    public class LevelOrderTraversalRev
    {
        public IList<IList<int>> LevelOrderBottom(TreeNode root)
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

            IList<IList<int>> result = new List<IList<int>>();

            int count = res.Count;

            for (int i = count - 1; i >= 0; i--)
                result.Add(res[i]);

            return result;
        }
    }
}
