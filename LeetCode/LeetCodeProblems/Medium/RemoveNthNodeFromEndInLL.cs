using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/remove-nth-node-from-end-of-list/
    //Given a linked list, remove the n-th node from the end of list and return its head.
    public class RemoveNthNodeFromEndInLL
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {

            if (head == null || (head.next == null && n == 1))
                return null;

            ListNode fakeHead = new ListNode(-1);
            fakeHead.next = head;

            ListNode pre = fakeHead;
            ListNode cur = fakeHead;

            //Move n steps with current 
            while (n > 0)
            {
                cur = cur.next;
                n--;
            }

            // Now move both pre and cur simultaneously
            // Till end of list
            while (cur.next != null)
            {
                pre = pre.next;
                cur = cur.next;
            }

            pre.next = pre.next.next;
            ListNode newHead = fakeHead.next;
            fakeHead.next = null;
            return newHead;

        }
    }
}
