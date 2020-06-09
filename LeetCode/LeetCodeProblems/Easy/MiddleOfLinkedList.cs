using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Easy
{

    //https://leetcode.com/problems/middle-of-the-linked-list/
    //Given a non-empty, singly linked list with head node head, return a middle node of linked list. If there are two middle nodes, return the second middle node.
    // O(n)
    public class MiddleOfLinkedList
    {
        public ListNode MiddleNode(ListNode head)
        {
            ListNode fast = head;
            ListNode slow = head;

            while (fast.next != null && fast.next.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }
            //Since we have to return last middle emlement in case of 2 middle elements.
            if (fast.next != null)
                slow = slow.next;

            return slow;
        }
    }
}
