using LeetCodeProblems.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/average-of-levels-in-binary-tree/
    //Given a non-empty binary tree, return the average value of the nodes on each level in the form of an array.
    public class LevelAverageInBinaryTree
    {
        public IList<double> AverageOfLevels(TreeNode root)
        {
            IList<double> res = new List<double>();
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
                    //Calculate Average and add it in result.
                    double sum = 0;
                    foreach (int node in oneLevelNode)
                        sum += node;
                    res.Add(sum / oneLevelNode.Count);
                }
            }
            return res;
        }
    }
}
