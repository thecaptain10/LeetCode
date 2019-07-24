using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/binary-tree-right-side-view/
    //Given a binary tree, imagine yourself standing on the right side of it, return the values of the nodes you can see ordered from top to bottom.
    public class BinaryTreeRightSideView
    {
        public IList<int> RightSideView(TreeNode root)
        {

            //Do Level Order Traversal and add last element of each level to result.
            IList<int> res = new List<int>();
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
                    //Add last element of each level to result list.
                    if (i == size - 1)
                        res.Add(top.val);

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
