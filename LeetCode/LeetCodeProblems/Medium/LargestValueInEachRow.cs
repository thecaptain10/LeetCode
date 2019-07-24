using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/find-largest-value-in-each-tree-row/
    //You need to find the largest value in each row of a binary tree.
    public class LargestValueInEachRow
    {
        public IList<int> LargestValues(TreeNode root)
        {
            //Do Level Order Traversal and add largest element of each level to result.
            IList<int> res = new List<int>();
            if (root == null)
            {
                return res;
            }
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Any())
            {
                int size = queue.Count;
                int max = int.MinValue;
                //For Each Level
                for (int i = 0; i < size; i++)
                {
                    TreeNode top = queue.Dequeue();
                    if (top == null) continue;

                    if (top.val > max)
                        max = top.val;

                    //Insert Left and then Right Tree.
                    if (top.left != null)
                        queue.Enqueue(top.left);
                    if (top.right != null)
                        queue.Enqueue(top.right);
                }

                res.Add(max);
            }
            return res;
        }
    }
}
