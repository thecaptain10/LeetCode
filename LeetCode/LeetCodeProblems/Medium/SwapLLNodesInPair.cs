using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/swap-nodes-in-pairs/
    //Given a linked list, swap every two adjacent nodes and return its head.
    public class SwapLLNodesInPair
    {
        public ListNode SwapPairs(ListNode head)
        {

            ListNode dummy = new ListNode(-1);
            dummy.next = head;

            ListNode pre = dummy;
            while (pre != null && pre.next != null && pre.next.next != null)
            {
                ListNode newEnd = pre.next;
                ListNode newStart = pre.next.next;

                pre.next = newStart;
                newEnd.next = newStart.next;
                newStart.next = newEnd;
                pre = newEnd;
            }

            ListNode newHead = dummy.next;
            dummy.next = null;

            return newHead;

        }
    }
}
