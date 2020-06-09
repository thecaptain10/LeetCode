using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/next-greater-node-in-linked-list/
    //We are given a linked list with head as the first node.  Let's number the nodes in the list: node_1, node_2, node_3, ... etc.
    // Each node may have a next larger value: for node_i, next_larger(node_i) is the node_j.val such that j > i, node_j.val > node_i.val, and j is the smallest possible choice.  If such a j does not exist, the next larger value is 0.
    //  Return an array of integers answer, where answer[i] = next_larger(node_{ i + 1}). 
    //O(n2)
    public class NextGreaterNodeInLinkedList
    {
        public int[] NextLargerNodes(ListNode head)
        {

            var values = new List<int>();
            for (var node = head; node != null; node = node.next)
                values.Add(node.val);

            var result = new int[values.Count];
            var stack = new Stack<int>();

            for (var i = 0; i < values.Count; i++)
            {
                while (stack.Any() && values[stack.Peek()] < values[i])
                    result[stack.Pop()] = values[i];
                stack.Push(i);
            }

            return result;

        }


    }
}
