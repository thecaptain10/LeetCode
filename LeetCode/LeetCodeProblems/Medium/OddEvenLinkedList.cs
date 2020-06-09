using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Medium
{
    //https://leetcode.com/problems/odd-even-linked-list/
    //Given a singly linked list, group all odd nodes together followed by the even nodes. Please note here we are talking about the node number and not the value in the nodes.You should try to do it in place.The program should run in O(1) space complexity and O(nodes) time complexity.
    // O(1) space complexity and O(nodes) 
    public class OddEvenLinkedList
    {
        public ListNode OddEvenList(ListNode head)
        {

            if (head == null)
                return null;

            ListNode slow = head;
            ListNode fast = head.next;

            if (fast == null)
                return head;


            ListNode oddHead = slow;
            ListNode evenHead = fast;

            ListNode currOdd = oddHead;
            ListNode currEven = evenHead;

            while (fast != null && fast.next != null)
            {
                slow = slow.next.next;
                fast = fast.next.next;

                currOdd.next = slow;
                currEven.next = fast;

                currOdd = currOdd.next;
                currEven = currEven.next;

            }

            currOdd.next = evenHead;

            return oddHead;


        }
    }
}
