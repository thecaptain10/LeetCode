using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/add-one-row-to-tree/
    //Given the root of a binary tree, then value v and depth d, you need to add a row of nodes with value v at the given depth d. The root node is at depth 1
    public class AddOneRowToTree
    {
        public TreeNode AddOneRow(TreeNode root, int v, int d)
        {

            if (root == null || d <= 0)
                return null;

            if (d == 1)
            {
                TreeNode newRoot = new TreeNode(v);
                newRoot.left = root;
                return newRoot;
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();
            int level = 1;
            queue.Enqueue(root);
            queue.Enqueue(null);
            while (queue.Count != 0)
            {
                //increment level
                level++;
                while (queue.Peek() != null)
                {
                    var node = queue.Dequeue();
                    if (level == d)
                    {
                        //if Desired level
                        TreeNode tempLeft = node.left;
                        TreeNode tempRight = node.right;
                        node.left = new TreeNode(v);
                        node.right = new TreeNode(v);

                        node.left.left = tempLeft;
                        node.right.right = tempRight;
                    }
                    else
                    {
                        if (node.left != null)
                            queue.Enqueue(node.left);
                        if (node.right != null)
                            queue.Enqueue(node.right);
                    }
                }
                queue.Dequeue();
                if (queue.Count != 0)
                    queue.Enqueue(null);
            }

            return root;
        }
    }
}
