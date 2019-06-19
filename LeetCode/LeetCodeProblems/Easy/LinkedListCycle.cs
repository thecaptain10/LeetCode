using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{
    //https://leetcode.com/problems/linked-list-cycle/

    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    public class LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null)
                return false;

            if (head.next == null)
                return false;

            ListNode slow = head;
            ListNode fast = head;

            // If there is a cycle, fast and slow pointers will be equal at some point of time for sure.
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                    return true;
            }
            return false;
        }
    }
}
