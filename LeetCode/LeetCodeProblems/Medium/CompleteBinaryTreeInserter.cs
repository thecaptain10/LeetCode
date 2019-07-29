using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/complete-binary-tree-inserter/
    //A complete binary tree is a binary tree in which every level, except possibly the last, is completely filled, and all nodes are as far left as possible.
    public class CBTInserter
    {
        TreeNode root;
        Queue<TreeNode> queue;
        public CBTInserter(TreeNode root)
        {
            this.root = root;
            queue = new Queue<TreeNode>();
        }

        public int Insert(int v)
        {
            queue.Clear();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();

                if (node.left != null && node.right != null)
                {
                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                }
                else
                {
                    if (node.left == null)
                    {
                        node.left = new TreeNode(v);
                    }
                    else
                    {
                        node.right = new TreeNode(v);
                    }

                    return node.val;
                }
            }

            return -1;
        }

        public TreeNode Get_root()
        {
            return root;
        }
    }
}
