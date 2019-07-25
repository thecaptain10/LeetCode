using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    public class N_AryNode
    {
        public int val;
        public IList<N_AryNode> children;

        public N_AryNode() { }
        public N_AryNode(int _val, IList<N_AryNode> _children)
        {
            val = _val;
            children = _children;
        }
    }


    //https://leetcode.com/problems/n-ary-tree-level-order-traversal/
    //Given an n-ary tree, return the level order traversal of its nodes' values. (ie, from left to right, level by level).
    public class N_AryLevelOrderTraversal
    {
        public IList<IList<int>> LevelOrder(N_AryNode root)
        {
            IList<IList<int>> res = new List<IList<int>>();
            Queue<N_AryNode> queue = new Queue<N_AryNode>();
            queue.Enqueue(root);
            while (queue.Any())
            {
                int size = queue.Count;
                List<int> oneLevelNode = new List<int>();
                //For Each Level
                for (int i = 0; i < size; i++)
                {
                    N_AryNode top = queue.Dequeue();
                    if (top == null) continue;
                    oneLevelNode.Add(top.val);

                    //Enqueue all the childrens of this node.
                    foreach (N_AryNode node in top.children)
                        queue.Enqueue(node);
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
