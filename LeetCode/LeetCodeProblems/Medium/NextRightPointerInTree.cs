using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/populating-next-right-pointers-in-each-node/
    //https://leetcode.com/problems/populating-next-right-pointers-in-each-node-ii/
    //You are given a perfect binary tree where all leaves are on the same level, and every parent has two children.

    public class NodeWithRightPointer
    {
        public int val;
        public NodeWithRightPointer left;
        public NodeWithRightPointer right;
        public NodeWithRightPointer next;
    }
    public class NextRightPointerInTree
    {
        public NodeWithRightPointer Connect(NodeWithRightPointer root)
        {
            if (root == null) { return null; }

            Queue<NodeWithRightPointer> q = new Queue<NodeWithRightPointer>();
            q.Enqueue(root);
            
            while (q.Count > 0)
            {
                int size = q.Count;
                NodeWithRightPointer prev = null;

                for (int i = 0; i < size; i++)
                {
                    //point next pointer to right child.
                    var node = q.Dequeue();
                    node.next = prev;
                    prev = node;

                    //Insert Right Child first here.
                    if (node.right != null) { q.Enqueue(node.right); }
                    if (node.left != null) { q.Enqueue(node.left); }
                }
            }

            return root;
        }
    }
}
