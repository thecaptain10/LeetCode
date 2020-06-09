using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/reorder-list/
    //Given a singly linked list L: L0→L1→…→Ln-1→Ln,
    //reorder it to: L0→Ln→L1→Ln-1→L2→Ln-2→…
    public class ReorderLinkedList
    {
        public void ReorderList(ListNode head)
        {

            if (head == null)
                return;

            ListNode slow = head;
            ListNode fast = head;

            ListNode prevSlow = new ListNode(0);
            prevSlow.next = head;

            //Find Middle
            while (fast != null && fast.next != null)
            {
                prevSlow = prevSlow.next;
                slow = slow.next;
                fast = fast.next.next;
            }

            //Reverse Second Half
            var secondHalfHead = slow.next;
            slow.next = null;
            var reverseCurrent = ReverseList(secondHalfHead);

            //Merge 
            var current = head;
            ListNode next, reverseNext;
            while (current != slow && reverseCurrent != null)
            {
                next = current.next;
                reverseNext = reverseCurrent.next;

                current.next = reverseCurrent;
                reverseCurrent.next = next;

                current = next;
                reverseCurrent = reverseNext;
            }
        }

        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;
            while (curr != null)
            {
                ListNode nextTemp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nextTemp;
            }
            return prev;
        }

    }
}
